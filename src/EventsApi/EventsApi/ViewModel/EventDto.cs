using System;
using System.ComponentModel.DataAnnotations;

namespace EventsApi.ViewModel
{
    public class EventDto
    {
        [Required]
        public string Description { get; set; }

        [Required]
        public int DoctorAttendeeId { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public int Id { get; set; }

        //relationships
        [Required]
        public int PatientAttendeeId { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The title is too long.")]
        public string Title { get; set; }
    }
}