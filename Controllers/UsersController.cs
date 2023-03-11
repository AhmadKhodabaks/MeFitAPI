using AutoMapper;
using MeFitAPI.Models.Domain;
using MeFitAPI.Models.DTO.UsersDTO;
using MeFitAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

namespace MeFitAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    private readonly IUserRepository _context;
    private readonly IMapper _mapper;

    public UsersController(IUserRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<User>>> GetAll()
    {
        var users = await _context.GetAllAsync();
        return Ok(users);
    }

    // GET api/<UsersController>/5
    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<User>> GetById(int id)
    {
        if (id == 0)
        {
            return BadRequest();
        }
        var user = await _context.GetAsync(u => u.Id == id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    // POST api/<UsersController>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<User>> Post([FromBody] UserCreateDTO value)
    {
        if (value == null)
        {
            return BadRequest(value);
        }

        User model = _mapper.Map<User>(value);
        await _context.CreateAsync(model);

        return CreatedAtRoute(nameof(GetById), new { id = model.Id }, value);
    }

    // DELETE api/<UsersController>/5
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

    // PATCH api/<UsersController>/5
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, JsonPatchDocument<UserUpdateDTO> patch)
    {
        if (patch == null || id == 0)
        {
            return BadRequest();
        }
        var value = await _context.GetAsync(u => u.Id == id, tracked: false);


        UserUpdateDTO userDTO = _mapper.Map<UserUpdateDTO>(value);

        if (userDTO == null)
        {
            return BadRequest();
        }
        patch.ApplyTo(userDTO, ModelState);

        User model = _mapper.Map<User>(userDTO);

        await _context.UpdateAsync(model);
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return NoContent();
    }
}
