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
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _eventService;
        private readonly IMapper _mapper;

        public EventsController(IMapper mapper, IEventService eventService)
        {
            _mapper = mapper;
            _eventService = eventService;
        }

        // DELETE: api/Events/5
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
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Event>), StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            var result = await _eventService.GetEvents();
            return Ok(_mapper.Map<IEnumerable<Event>, IEnumerable<EventDto>>(result));
        }

        // POST: api/Events
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
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