using System;
using System.ComponentModel.DataAnnotations;

namespace EventsApi.ViewModel
{
    /// <summary>
    /// The event dto class
    /// </summary>
    public class EventDto
    {
        /// <summary>
        /// Gets or sets the value of the description
        /// </summary>
        [Required]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value of the doctor attendee id
        /// </summary>
        [Required]
        public int DoctorAttendeeId { get; set; }

        /// <summary>
        /// Gets or sets the value of the end time
        /// </summary>
        [Required]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the value of the id
        /// </summary>
        public int Id { get; set; }

        //relationships
        /// <summary>
        /// Gets or sets the value of the patient attendee id
        /// </summary>
        [Required]
        public int PatientAttendeeId { get; set; }

        /// <summary>
        /// Gets or sets the value of the start time
        /// </summary>
        [Required]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Gets or sets the value of the title
        /// </summary>
        [Required]
        [MaxLength(100, ErrorMessage = "The title is too long.")]
        public string Title { get; set; }
    }
}