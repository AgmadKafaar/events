using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EventsApi.ViewModel
{
    public class EventDto
    {
        [Required]
        public string Description { get; set; }

        public AttendeeDto Doctor { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        public int Id { get; set; }

        //relationships
        public AttendeeDto Patient { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The title is too long.")]
        public string Title { get; set; }

        private ICollection<AttendeeDto> Attendees => new List<AttendeeDto>(2)
        {
            Patient,
            Doctor
        };
    }
}