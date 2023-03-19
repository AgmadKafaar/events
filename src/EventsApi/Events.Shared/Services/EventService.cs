﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Events.Shared.Infrastructure.Data;
using Events.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Events.Shared.Services
{
    public class EventService : IEventService
    {
        private readonly EventsContext _context;

        public EventService(EventsContext context)
        {
            _context = context;
        }

        public async Task<Event> DeleteEvent(int id)
        {
            var @event = await _context.Events.FindAsync(id).ConfigureAwait(false);
            if (@event == null)
            {
                return null;
            }

            _context.Events.Remove(@event);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return @event;
        }

        public async Task<Event> GetEvent(int id)
        {
            return await _context.Events.FindAsync(id).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Event>> GetEvents()
        {
            return await _context.Events.ToListAsync().ConfigureAwait(false);
        }

        public async Task<Event> CreateEvent(Event @event)
        {
            _context.Events.Add(@event);
            await _context.SaveChangesAsync().ConfigureAwait(false);
            return @event;
        }

        public async Task<Event> UpdateEvent(int id, Event @event)
        {
            _context.Entry(@event).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EventExists(id))
                {
                    return null;
                }
                else
                {
                    throw;
                }
            }

            return @event;
        }
        private bool EventExists(int id)
        {
            return _context.Events.Any(e => e.Id == id);
        }
    }
}