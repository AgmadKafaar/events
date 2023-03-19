using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.Shared.Models
{
    /// <summary>
    /// The event class
    /// </summary>
    public class Event
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
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the value of the end time
        /// </summary>
        [Required]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Gets or sets the value of the id
        /// </summary>
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

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

        /// <summary>
        /// Gets or sets the value of the row version
        /// </summary>
        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}