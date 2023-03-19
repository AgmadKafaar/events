using Events.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Events.Shared.Infrastructure.Data
{
    /// <summary>
    /// The events context class
    /// </summary>
    /// <seealso cref="DbContext"/>
    public class EventsContext : DbContext
    {
        /// <summary>
        /// Gets the value of the db path
        /// </summary>
        public string DbPath { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsContext"/> class
        /// </summary>
        public EventsContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "events.db");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EventsContext"/> class
        /// </summary>
        /// <param name="options">The options</param>
        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "events.db");
        }

        /// <summary>
        /// Ons the configuring using the specified options builder
        /// </summary>
        /// <param name="optionsBuilder">The options builder</param>
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite($"Data Source ={DbPath}");

        /// <summary>
        /// Ons the model creating using the specified model builder
        /// </summary>
        /// <param name="modelBuilder">The model builder</param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(p => p.RowVersion)
                .IsRowVersion();

            modelBuilder.Entity<AttendeeType>().HasData(
                new AttendeeType() { Id = 1, Description = "Patient" },
                new AttendeeType() { Id = 2, Description = "Doctor" }
                );
        }

        /// <summary>
        /// Sets or gets the value of the attendees
        /// </summary>
        public virtual DbSet<Attendee> Attendees { set; get; }
        /// <summary>
        /// Sets or gets the value of the attendees type
        /// </summary>
        public virtual DbSet<AttendeeType> AttendeesType { set; get; }
        /// <summary>
        /// Sets or gets the value of the events
        /// </summary>
        public virtual DbSet<Event> Events { set; get; }
    }
}