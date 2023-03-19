using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Events.Shared.Models
{
    public class Event
    {
        //relationships
        public ICollection<Attendee> Attendees { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The title is too long.")]
        public string Title { get; set; }

        [Timestamp]
        public byte[] RowVersion { get; set; }
    }
}