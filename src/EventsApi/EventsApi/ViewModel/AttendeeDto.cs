using System.ComponentModel.DataAnnotations;

namespace EventsApi.ViewModel
{
    /// <summary>
    /// The attendee dto class
    /// </summary>
    public class AttendeeDto
    {
        // relationships
        /// <summary>
        /// Gets or sets the value of the attendee type
        /// </summary>
        public AttendeeTypeDto AttendeeType { get; set; }

        /// <summary>
        /// Gets or sets the value of the email address
        /// </summary>
        [Required]
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the value of the id
        /// </summary>
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