using System.ComponentModel.DataAnnotations;

namespace EventsApi.ViewModel
{
    public class AttendeeDto
    {
        // relationships
        public AttendeeTypeDto AttendeeType { get; set; }

        [Required]
        [EmailAddress(ErrorMessage = "Email address is not valid")]
        public string EmailAddress { get; set; }

        public int Id { get; set; }

        public bool IsAttending { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The provided value is too long.")]
        [MinLength(5, ErrorMessage = "The provided value is too Short.")]
        public string Name { get; set; }
    }
}