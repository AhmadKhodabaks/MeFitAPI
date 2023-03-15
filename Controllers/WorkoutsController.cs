using AutoMapper;
using MeFitAPI.Models.Domain;
using MeFitAPI.Models.DTO.UsersDTO;
using MeFitAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeFitAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class WorkoutsController : ControllerBase
{
    private readonly IWorkoutRepository _context;
    private readonly IMapper _mapper;

    public WorkoutsController(IWorkoutRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<Workout>>> GetAll()
    {
        var workouts = await _context.GetAllAsync();
        return Ok(workouts);
    }

    // GET api/<WorkoutsController>/5
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Workout>> GetById(int id, string? navigationProperty)
    {
        if (id == 0)
        {
            return BadRequest();
        }

        if (!string.IsNullOrEmpty(navigationProperty) &&
        typeof(Workout).GetProperty(navigationProperty) == null)
        {
            return BadRequest("Invalid navigation property");
        }

        var workout = await _context.GetAsync(u => u.Id == id, navigationProperty);
        if (workout == null)
        {
            return NotFound();
        }
        return Ok(workout);
    }

    // POST api/<WorkoutsController>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Workout>> Post([FromBody] WorkoutCreateDTO value)
    {
        if (value == null)
        {
            return BadRequest(value);
        }

        Workout model = _mapper.Map<Workout>(value);
        await _context.CreateAsync(model);

        return CreatedAtRoute(nameof(GetById), new { id = model.Id }, value);
    }

    // DELETE api/<WorkoutsController>/5
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

    // PATCH api/<WorkoutsController>/5
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, JsonPatchDocument<WorkoutUpdateDTO> patch)
    {
        if (patch == null || id == 0)
        {
            return BadRequest();
        }
        var value = await _context.GetAsync(u => u.Id == id, tracked: false);


        WorkoutUpdateDTO workoutDTO = _mapper.Map<WorkoutUpdateDTO>(value);

        if (workoutDTO == null)
        {
            return BadRequest();
        }
        patch.ApplyTo(workoutDTO, ModelState);

        Workout model = _mapper.Map<Workout>(workoutDTO);

        await _context.UpdateAsync(model);
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return NoContent();
    }
}
