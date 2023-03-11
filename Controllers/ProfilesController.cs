using AutoMapper;
using MeFitAPI.DataAccess;
using MeFitAPI.Models.Domain;
using MeFitAPI.Models.DTO.ProfilesDTO;
using MeFitAPI.Repository.IRepository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MeFitAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProfilesController : ControllerBase
{
    private readonly IProfileRepository _context;
    private readonly IMapper _mapper;

    public ProfilesController(IProfileRepository context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<IEnumerable<Models.Domain.Profile>>> GetAll()
    {
        var profiles = await _context.GetAllAsync();
        return Ok(profiles);
    }

    // GET api/<ProfilesController>/5
    [HttpGet("{id}", Name = "GetById")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<Models.Domain.Profile>> GetById(int id)
    {
        if (id == 0)
        {
            return BadRequest();
        }
        var profile = await _context.GetAsync(u => u.Id == id);
        if (profile == null)
        {
            return NotFound();
        }
        return Ok(profile);
    }

    // POST api/<ProfilesController>
    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<Models.Domain.Profile>> Post([FromBody] ProfileCreateDTO value)
    {
        if (value == null)
        {
            return BadRequest(value);
        }

        Models.Domain.Profile model = _mapper.Map<Models.Domain.Profile>(value);
        await _context.CreateAsync(model);

        return CreatedAtRoute("GetById", new { id = model.Id }, value);
    }

    // DELETE api/<ProfilesController>/5
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

    // PATCH api/<ProfilesController>/5
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [HttpPatch("{id}")]
    public async Task<IActionResult> Patch(int id, JsonPatchDocument<ProfileUpdateDTO> patch)
    {
        if (patch == null || id == 0)
        {
            return BadRequest();
        }
        var value = await _context.GetAsync(u => u.Id == id, tracked: false);


        ProfileUpdateDTO profileDTO = _mapper.Map<ProfileUpdateDTO>(value);         

        if (profileDTO == null)
        {
            return BadRequest();
        }
        patch.ApplyTo(profileDTO, ModelState);

        Models.Domain.Profile model = _mapper.Map<Models.Domain.Profile>(profileDTO); 
    
        await _context.UpdateAsync(model);
        if (!ModelState.IsValid)
        {
            return BadRequest(ModelState);
        }
        return NoContent();
    }
}
