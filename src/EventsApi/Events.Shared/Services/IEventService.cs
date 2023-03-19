using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.Shared.Models;

namespace Events.Shared.Services
{
    public interface IEventService
    {
        Task<Event> DeleteEvent(int id);
        Task<Event> GetEvent(int id);
        Task<IEnumerable<Event>> GetEvents();
        Task<Event> CreateEvent(Event @event);
        Task<Event> UpdateEvent(int id, Event @event);
    }
}
