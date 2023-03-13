using AutoMapper;
using MeFitAPI.Models.Domain;
using MeFitAPI.Models.DTO.UsersDTO;
using MeFitAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MeFitAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class GoalsController : ControllerBase
{
    private readonly IGoalRepository _context;
    private readonly IMapper _mapper;

    public GoalsController(IGoalRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<Goal>>> GetAll()
    {
        var goals = await _context.GetAllAsync();
        return Ok(goals);
    }

    // GET api/<GoalsController>/5
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Goal>> GetById(int id)
    {
        if (id == 0)
        {
            return BadRequest();
        }
        var goal = await _context.GetAsync(u => u.Id == id);
        if (goal == null)
        {
            return NotFound();
        }
        return Ok(goal);
    }

    // POST api/<GoalsController>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Goal>> Post([FromBody] GoalCreateDTO value)
    {
        if (value == null)
        {
            return BadRequest(value);
        }

        Goal model = _mapper.Map<Goal>(value);
        await _context.CreateAsync(model);

        return CreatedAtRoute(nameof(GetById), new { id = model.Id }, value);
    }

    // DELETE api/<GoalsController>/5
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if (id == 0)
        {
            return BadRequest();
        }
        var value = await _context.GetAsync(u => u.Id == id);
        if (value == null)
        {
            return NotFound();
        }
        await _context.RemoveAsync(value);
        return NoContent();
    }

    // PATCH api/<GoalsController>/5
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, JsonPatchDocument<GoalUpdateDTO> patch)
    {
        if (patch == null || id == 0)
        {
            return BadRequest();
        }
        var value = await _context.GetAsync(u => u.Id == id, tracked: false);


        GoalUpdateDTO GoalDTO = _mapper.Map<GoalUpdateDTO>(value);

        if (GoalDTO == null)
        {
            return BadRequest();
        }
        patch.ApplyTo(GoalDTO, ModelState);

        Goal model = _mapper.Map<Goal>(GoalDTO);

        await _context.UpdateAsync(model);
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return NoContent();
    }
}