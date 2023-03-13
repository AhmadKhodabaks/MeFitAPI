using AutoMapper;
using MeFitAPI.Models.Domain;
using MeFitAPI.Models.DTO.UsersDTO;
using MeFitAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MeFitAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ExercisesController : ControllerBase
{
    private readonly IExerciseRepository _context;
    private readonly IMapper _mapper;

    public ExercisesController(IExerciseRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<Exercise>>> GetAll()
    {
        var exercises = await _context.GetAllAsync();
        return Ok(exercises);
    }

    // GET api/<ExercisesController>/5
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Exercise>> GetById(int id)
    {
        if (id == 0)
        {
            return BadRequest();
        }
        var exercise = await _context.GetAsync(u => u.Id == id);
        if (exercise == null)
        {
            return NotFound();
        }
        return Ok(exercise);
    }

    // POST api/<ExercisesController>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Exercise>> Post([FromBody] ExerciseCreateDTO value)
    {
        if (value == null)
        {
            return BadRequest(value);
        }

        Exercise model = _mapper.Map<Exercise>(value);
        await _context.CreateAsync(model);

        return CreatedAtRoute(nameof(GetById), new { id = model.Id }, value);
    }

    // DELETE api/<ExercisesController>/5
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

    // PATCH api/<ExercisesController>/5
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, JsonPatchDocument<ExerciseUpdateDTO> patch)
    {
        if (patch == null || id == 0)
        {
            return BadRequest();
        }
        var value = await _context.GetAsync(u => u.Id == id, tracked: false);


        ExerciseUpdateDTO ExerciseDTO = _mapper.Map<ExerciseUpdateDTO>(value);

        if (ExerciseDTO == null)
        {
            return BadRequest();
        }
        patch.ApplyTo(ExerciseDTO, ModelState);

        Exercise model = _mapper.Map<Exercise>(ExerciseDTO);

        await _context.UpdateAsync(model);
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return NoContent();
    }
}
