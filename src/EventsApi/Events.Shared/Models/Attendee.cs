using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events.Shared.Models
{
    public class Attendee
    {
        public int Id { get; set; }
        public string Name  { get; set; }
        public string EmailAddress { get; set; }

        // relationships
        public AttendeeType AttendeeType { get; set; }
        public ICollection<Event> Events { get; set; }
    }
}
