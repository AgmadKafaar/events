namespace Events.Shared.Models
{
    /// <summary>
    /// The message class
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Gets or sets the value of the message content
        /// </summary>
        public string MessageContent { get; set; }
        /// <summary>
        /// Gets or sets the value of the to
        /// </summary>
        public string To { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message"/> class
        /// </summary>
        /// <param name="messageContent">The message content</param>
        /// <param name="to">The to</param>
        public Message(string messageContent, string to)
        {
            MessageContent = messageContent;
            To = to;
        }
    }
}