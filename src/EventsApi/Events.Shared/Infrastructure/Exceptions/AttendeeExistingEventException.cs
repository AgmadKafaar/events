using System;
using System.Runtime.Serialization;

namespace Events.Shared.Infrastructure.Exceptions
{
    public class AttendeeExistingEventException : ApplicationException
    {
        public AttendeeExistingEventException()
        {
        }

        protected AttendeeExistingEventException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public AttendeeExistingEventException(string message) : base(message)
        {
        }

        public AttendeeExistingEventException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}