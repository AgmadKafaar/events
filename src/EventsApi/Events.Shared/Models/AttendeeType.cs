using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.Shared.Models
{
    /// <summary>
    /// The attendee type class
    /// </summary>
    public class AttendeeType
    {
        //relationships
        /// <summary>
        /// Gets or sets the value of the attendees
        /// </summary>
        public ICollection<Attendee> Attendees { get; set; }

        /// <summary>
        /// Gets or sets the value of the description
        /// </summary>
        [Required]
        [MaxLength(7, ErrorMessage = "Description is too long")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value of the id
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
    }
}