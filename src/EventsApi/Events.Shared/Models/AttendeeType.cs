using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.Shared.Models
{
    public class AttendeeType
    {
        //relationships
        public ICollection<Attendee> Attendees { get; set; }

        [Required]
        [MaxLength(7, ErrorMessage = "Description is too long")]
        public string Description { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}