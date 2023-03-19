using AutoMapper;
using Events.Shared.Infrastructure.Data;
using Events.Shared.Models;
using EventsApi.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        private readonly EventsContext _context;
        private readonly IMapper _mapper;

        public AttendeesController(EventsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // DELETE: api/Attendees/5
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteAttendee(int id)
        {
            var attendee = await _context.Attendees.FindAsync(id);
            if (attendee == null)
            {
                return NotFound();
            }

            _context.Attendees.Remove(attendee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/Attendees/5
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(AttendeeDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AttendeeDto>> GetAttendee(int id)
        {
            var attendee = await _context.Attendees.FindAsync(id);

            if (attendee == null)
            {
                return NotFound();
            }

            var result = _mapper.Map<Attendee, AttendeeDto>(attendee);
            return result;
        }

        // GET: api/Attendees
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<AttendeeDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AttendeeDto>>> GetAttendees()
        {
            var result = await _context.Attendees.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<Attendee>, IEnumerable<AttendeeDto>>(result));
        }

        // POST: api/Attendees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        [ProducesResponseType(typeof(Attendee), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<AttendeeDto>> PostAttendee(AttendeeDto attendee)
        {
            var mappedAttendee = _mapper.Map<AttendeeDto, Attendee>(attendee);
            _context.Attendees.Add(mappedAttendee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAttendee", new { id = mappedAttendee.Id }, mappedAttendee);
        }

        // PUT: api/Attendees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutAttendee(int id, AttendeeDto attendee)
        {
            if (id != attendee.Id)
            {
                return BadRequest();
            }

            var mappedObj = _mapper.Map<AttendeeDto, Attendee>(attendee);

            _context.Entry(mappedObj).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AttendeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        private bool AttendeeExists(int id)
        {
            return _context.Attendees.Any(e => e.Id == id);
        }
    }
}