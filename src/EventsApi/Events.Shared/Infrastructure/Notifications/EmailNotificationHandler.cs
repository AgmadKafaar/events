using Events.Shared.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Events.Shared.Infrastructure.Notifications
{
    public class EmailNotificationHandler : INotificationHandler
    {
        public Task Publish(IEnumerable<Message> messages)
        {
            // if running own mail server, iterate through all messages and post one-by-one
            // if using and external provider with batch uploads like twillio/ sendgrid, send a batch

            return Task.CompletedTask;
        }
    }
}