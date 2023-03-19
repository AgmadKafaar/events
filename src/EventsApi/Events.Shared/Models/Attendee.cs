using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.Shared.Models
{
    /// <summary>
    /// The attendee class
    /// </summary>
    public class Attendee
    {
        // relationships
        /// <summary>
        /// Gets or sets the value of the attendee type
        /// </summary>
        public AttendeeType AttendeeType { get; set; }

        /// <summary>
        /// Gets or sets the value of the email address
        /// </summary>
        [Required]
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the value of the events
        /// </summary>
        public ICollection<Event> Events { get; set; }

        /// <summary>
        /// Gets or sets the value of the id
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the value of the is attending
        /// </summary>
        public bool IsAttending { get; set; }

        /// <summary>
        /// Gets or sets the value of the name
        /// </summary>
        [Required]
        [MaxLength(100, ErrorMessage = "The provided value is too long.")]
        [MinLength(5, ErrorMessage = "The provided value is too Short.")]
        public string Name { get; set; }
    }
}