using MeFitAPI.DataAccess;
using MeFitAPI.Models.Domain;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MeFitAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilesController : ControllerBase
    {
        private readonly MeFitDbContext _context;

        public ProfilesController(MeFitDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public ActionResult<IEnumerable<Profile>> GetAll()
        {
            var profiles = _context.Profiles.ToList();
            return Ok(profiles);
        }

        // GET api/<ProfilesController>/5
        [HttpGet("{id}", Name = "GetById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<Profile> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var profile = _context.Profiles.FirstOrDefault(u => u.Id == id);
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
        public ActionResult<Profile> Post([FromBody] Profile value)
        {
            if (value == null)
            {
                return BadRequest(value);
            }
            if (value.Id > 0)
            {
                return BadRequest("Cannot specify ID value when creating new object.");
            }
            _context.Profiles.Add(value);
            _context.SaveChanges();

            return CreatedAtRoute("GetById", new { id = value.Id }, value);

        }

        // PUT api/<ProfilesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProfilesController>/5
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            var value = _context.Profiles.FirstOrDefault(u => u.Id == id);
            if (value == null)
            {
                return NotFound();
            }
            _context.Profiles.Remove(value);
            _context.SaveChanges();
            return NoContent();
        }

        // PATCH api/<ProfilesController>/5
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [HttpPatch("{id}")]
        public IActionResult Patch(int id, JsonPatchDocument<Profile> patch)
        {
            if (patch == null || id == 0)
            {
                return BadRequest();
            }
            var value = _context.Profiles.AsNoTracking().FirstOrDefault(u => u.Id == id);
            if (value == null)
            {
                return BadRequest();
            }
            patch.ApplyTo(value, ModelState);

            Profile model = new Profile()
            {
                Id = value.Id,
                Disabilities = value.Disabilities,
                Address = value.Address,
                AddressId = value.AddressId,
                GoalId = value.GoalId,
                Height = value.Height,
                MedicalConditions = value.MedicalConditions,
                ProgramId = value.ProgramId,
                UserId = value.UserId,
                Weight = value.Weight,
                WorkoutId = value.WorkoutId,
            };

            _context.Profiles.Update(model);
            _context.SaveChanges();
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return NoContent();
        }
    }
}
