using AutoMapper;
using Events.Shared.Models;
using Events.Shared.Services;
using EventsApi.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventsApi.Controllers
{
    /// <summary>
    /// The events controller class
    /// </summary>
    /// <seealso cref="ControllerBase"/>
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        /// <summary>
        /// The event service
        /// </summary>
        private readonly IEventService _eventService;
        /// <summary>
        /// The mapper
        /// </summary>
        private readonly IMapper _mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsController"/> class
        /// </summary>
        /// <param name="mapper">The mapper</param>
        /// <param name="eventService">The event service</param>
        public EventsController(IMapper mapper, IEventService eventService)
        {
            _mapper = mapper;
            _eventService = eventService;
        }

        // DELETE: api/Events/5
        /// <summary>
        /// Deletes the event using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>A task containing the action result</returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var @event = await _eventService.DeleteEvent(id);
            if (@event == null)
            {
                return NotFound();
            }
            return NoContent();
        }

        // GET: api/Events/5
        /// <summary>
        /// Gets the event using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>The result</returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(EventDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<EventDto>> GetEvent(int id)
        {
            var @event = await _eventService.GetEvent(id);

            if (@event == null)
            {
                return NotFound();
            }
            var result = _mapper.Map<Event, EventDto>(@event);
            return result;
        }

        // GET: api/Events
        /// <summary>
        /// Gets the events
        /// </summary>
        /// <returns>A task containing an action result of i enumerable event</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Event>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            var result = await _eventService.GetEvents();
            return Ok(_mapper.Map<IEnumerable<Event>, IEnumerable<EventDto>>(result));
        }

        // POST: api/Events
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Posts the event using the specified event
        /// </summary>
        /// <param name="@event">The event</param>
        /// <returns>A task containing an action result of event dto</returns>
        [HttpPost]
        [ProducesResponseType(typeof(EventDto), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<EventDto>> PostEvent(EventDto @event)
        {
            var mappedEvent = _mapper.Map<EventDto, Event>(@event);
            mappedEvent = await _eventService.CreateEvent(mappedEvent);
            return CreatedAtAction("GetEvent", new { id = mappedEvent.Id }, mappedEvent);
        }

        // PUT: api/Events/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        /// <summary>
        /// Puts the event using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <param name="@event">The event</param>
        /// <returns>A task containing the action result</returns>
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ProblemDetails), StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> PutEvent(int id, EventDto @event)
        {
            if (id != @event.Id)
            {
                return BadRequest();
            }
            var mappedObj = _mapper.Map<EventDto, Event>(@event);
            mappedObj = await _eventService.UpdateEvent(id, mappedObj);
            return mappedObj == null ? NotFound() : NoContent();
        }
    }
}