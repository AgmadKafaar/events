using Events.Shared.Infrastructure.Data;
using Events.Shared.Infrastructure.Exceptions;
using Events.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Events.Shared.Services
{
    /// <summary>
    /// The event service class
    /// </summary>
    /// <seealso cref="IEventService"/>
    public class EventService : IEventService
    {
        /// <summary>
        /// The context
        /// </summary>
        private readonly EventsContext _context;

        /// <summary>
        /// Initializes a new instance of the <see cref="EventService"/> class
        /// </summary>
        /// <param name="context">The context</param>
        public EventService(EventsContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Creates the event using the specified event
        /// </summary>
        /// <param name="@event">The event</param>
        /// <exception cref="AttendeeExistingEventException">Attendees have exiting events between {@event.StartTime} and {@event.EndTime}</exception>
        /// <returns>The event</returns>
        public async Task<Event> CreateEvent(Event @event)
        {
            var someoneHasExistingEvents = await SomeoneHasExistingEvents(@event);
            if (someoneHasExistingEvents)
            {
                throw new AttendeeExistingEventException($"Attendees have exiting events between {@event.StartTime} and {@event.EndTime}");
            }

            _context.Events.Add(@event);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return @event;
        }

        /// <summary>
        /// Deletes the event using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>The event</returns>
        public async Task<Event> DeleteEvent(int id)
        {
            var @event = await _context.Events.FindAsync(id).ConfigureAwait(false);
            if (@event == null)
            {
                return null;
            }

            _context.Events.Remove(@event);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return @event;
        }

        /// <summary>
        /// Gets the event using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>A task containing the event</returns>
        public async Task<Event> GetEvent(int id)
        {
            return await _context.Events.FindAsync(id).ConfigureAwait(false);
        }

        /// <summary>
        /// Gets the events
        /// </summary>
        /// <returns>A task containing an enumerable of event</returns>
        public async Task<IEnumerable<Event>> GetEvents()
        {
            return await _context.Events.ToListAsync().ConfigureAwait(false);
        }

        /// <summary>
        /// Updates the event using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <param name="@event">The event</param>
        /// <returns>The event</returns>
        public async Task<Event> UpdateEvent(int id, Event @event)
        {
            _context.Entry(@event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return @event;
        }

        /// <summary>
        /// Describes whether this instance event exists
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>The bool</returns>
        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }

        /// <summary>
        /// Someones the has existing events using the specified event
        /// </summary>
        /// <param name="@event">The event</param>
        /// <returns>The someone has existing events</returns>
        private async Task<bool> SomeoneHasExistingEvents(Event @event)
        {
            var someoneHasExistingEvents = false;
            var attendeeIds = @event.Attendees.Select(x => x.Id);
            someoneHasExistingEvents = await _context.Attendees.AnyAsync(attendee =>
                attendeeIds.Contains(attendee.Id) &&
                attendee.Events.Any(e => e.StartTime >= @event.StartTime && e.EndTime >= @event.EndTime));
            return someoneHasExistingEvents;
        }
    }
}