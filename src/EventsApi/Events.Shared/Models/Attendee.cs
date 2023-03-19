using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.Shared.Models
{
    public class Attendee
    {
        // relationships
        public AttendeeType AttendeeType { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        public string EmailAddress { get; set; }

        public ICollection<Event> Events { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public bool IsAttending { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The provided value is too long.")]
        [MinLength(5, ErrorMessage = "The provided value is too Short.")]
        public string Name { get; set; }
    }
}