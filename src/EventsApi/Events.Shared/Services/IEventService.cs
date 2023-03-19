using Events.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Shared.Services
{
    /// <summary>
    /// The event service interface
    /// </summary>
    public interface IEventService
    {
        /// <summary>
        /// Creates the event using the specified event
        /// </summary>
        /// <param name="@event">The event</param>
        /// <returns>A task containing the event</returns>
        Task<Event> CreateEvent(Event @event);

        /// <summary>
        /// Deletes the event using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>A task containing the event</returns>
        Task<Event> DeleteEvent(int id);

        /// <summary>
        /// Gets the event using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <returns>A task containing the event</returns>
        Task<Event> GetEvent(int id);

        /// <summary>
        /// Gets the events
        /// </summary>
        /// <returns>A task containing an enumerable of event</returns>
        Task<IEnumerable<Event>> GetEvents();

        /// <summary>
        /// Updates the event using the specified id
        /// </summary>
        /// <param name="id">The id</param>
        /// <param name="@event">The event</param>
        /// <returns>A task containing the event</returns>
        Task<Event> UpdateEvent(int id, Event @event);
    }
}