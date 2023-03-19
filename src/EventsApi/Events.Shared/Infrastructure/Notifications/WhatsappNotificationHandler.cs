using Events.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Shared.Infrastructure.Notifications
{
    /// <summary>
    /// The whatsapp notification handler class
    /// </summary>
    /// <seealso cref="INotificationHandler"/>
    public class WhatsappNotificationHandler : INotificationHandler
    {
        /// <summary>
        /// Publishes the messages
        /// </summary>
        /// <param name="messages">The messages</param>
        public Task Publish(IEnumerable<Message> messages)
        {
            // whatsapp allows you send upto 200 messages per batch
            // integrate with existing library/api that runs a whatsapp business api - eg clickatel / smooches / twillio

            return Task.CompletedTask;
        }
    }
}