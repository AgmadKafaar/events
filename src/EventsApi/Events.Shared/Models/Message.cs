namespace Events.Shared.Models
{
    public class Message
    {
        public string MessageContent { get; set; }
        public string To { get; set; }

        public Message(string messageContent, string to)
        {
            MessageContent = messageContent;
            To = to;
        }
    }
}