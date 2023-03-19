using Events.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Shared.Infrastructure.Notifications
{
    public class WhatsappNotificationHandler : INotificationHandler
    {
        public Task Publish(IEnumerable<Message> messages)
        {
            // whatsapp allows you send upto 200 messages per batch
            // integrate with existing library/api that runs a whatsapp business api - eg clickatel / smooches / twillio

            return Task.CompletedTask;
        }
    }
}