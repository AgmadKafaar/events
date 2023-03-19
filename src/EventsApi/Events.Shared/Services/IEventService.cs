using Events.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Shared.Services
{
    public interface IEventService
    {
        Task<Event> CreateEvent(Event @event);

        Task<Event> DeleteEvent(int id);

        Task<Event> GetEvent(int id);

        Task<IEnumerable<Event>> GetEvents();

        Task<Event> UpdateEvent(int id, Event @event);
    }
}