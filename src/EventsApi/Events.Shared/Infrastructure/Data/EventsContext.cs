using Events.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Events.Shared.Infrastructure.Data
{
    public class EventsContext : DbContext
    {

        public string DbPath { get; }
        public EventsContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "events.db");
        }

        public EventsContext(DbContextOptions<EventsContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlite($"Data Source ={DbPath}");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Event>()
                .Property(p => p.RowVersion)
                .IsRowVersion();
        }

        public virtual DbSet<Attendee> Attendees { set; get; }
        public virtual DbSet<AttendeeType> AttendeesType { set; get; }
        public virtual DbSet<Event> Events { set; get; }
    }
}