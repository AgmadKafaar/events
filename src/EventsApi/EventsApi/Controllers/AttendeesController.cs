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
    /// <summary>
    /// The attendees controller class
    /// </summary>
    /// <seealso cref="ControllerBase"/>
    [Route("api/[controller]")]
    [ApiController]
    public class AttendeesController : ControllerBase
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly EventsContext _context;
        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="AttendeesController"/> class
        /// </summary>
        /// <param name="context">The context</param>
        /// <param name="mapper">The mapper</param>
        public AttendeesController(EventsContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // DELETE: api/Attendees/5
        /// <summary>
        /// Deletes the attendee using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>A task containing the action result</returns>
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
        /// <summary>
        /// Gets the attendee using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>The result</returns>
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
        /// <summary>
        /// Gets the attendees
        /// </summary>
        /// <returns>A task containing an action result of i enumerable attendee dto</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<AttendeeDto>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AttendeeDto>>> GetAttendees()
        {
            var result = await _context.Attendees.ToListAsync();
            return Ok(_mapper.Map<IEnumerable<Attendee>, IEnumerable<AttendeeDto>>(result));
        }

        // POST: api/Attendees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Posts the attendee using the specified attendee
        /// </summary>
        /// <param name="attendee">The attendee</param>
        /// <returns>A task containing an action result of attendee dto</returns>
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
        /// <summary>
        /// Puts the attendee using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <param name="attendee">The attendee</param>
        /// <returns>A task containing the action result</returns>
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

        /// <summary>
        /// Describes whether this instance attendee exists
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>The bool</returns>
        private bool AttendeeExists(int id)
        {
            return _context.Attendees.Any(e => e.Id == id);
        }
    }
}