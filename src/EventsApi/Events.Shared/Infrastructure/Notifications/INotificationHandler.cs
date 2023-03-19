using Events.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Shared.Infrastructure.Notifications
{
    /// <summary>
    /// The notification handler interface
    /// </summary>
    public interface INotificationHandler
    {
        /// <summary>
        /// Publishes the messages
        /// </summary>
        /// <param name="messages">The messages</param>
        Task Publish(IEnumerable<Message> messages);
    }
}