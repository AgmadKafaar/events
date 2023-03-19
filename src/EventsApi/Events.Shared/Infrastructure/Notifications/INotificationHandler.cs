using Events.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Shared.Infrastructure.Notifications
{
    public interface INotificationHandler
    {
        Task Publish(IEnumerable<Message> messages);
    }
}