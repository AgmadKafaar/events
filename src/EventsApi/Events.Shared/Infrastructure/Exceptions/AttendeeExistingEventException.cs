using System;
using System.Runtime.Serialization;

namespace Events.Shared.Infrastructure.Exceptions
{
    /// <summary>
    /// The attendee existing event exception class
    /// </summary>
    /// <seealso cref="ApplicationException"/>
    public class AttendeeExistingEventException : ApplicationException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttendeeExistingEventException"/> class
        /// </summary>
        public AttendeeExistingEventException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttendeeExistingEventException"/> class
        /// </summary>
        /// <param name="info">The info</param>
        /// <param name="context">The context</param>
        protected AttendeeExistingEventException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttendeeExistingEventException"/> class
        /// </summary>
        /// <param name="message">The message</param>
        public AttendeeExistingEventException(string message) : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AttendeeExistingEventException"/> class
        /// </summary>
        /// <param name="message">The message</param>
        /// <param name="innerException">The inner exception</param>
        public AttendeeExistingEventException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}