using EncantoPaisa.DAL;
using EncantoPaisa.Domain.Interfaces;
using EncantoPaisa.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace EncantoPaisa.Domain.Services
{
    public class EventsService : IEventsService
    {
        private readonly DataBaseContext _context;

        public EventsService(DataBaseContext context)
        {
            _context = context;
        }

        public Events CreateEvents(Events events)
        {
            try
            {
                events.Id = Guid.NewGuid();
                events.IsCompleted = false;

                _context.Events.Add(events);
                _context.SaveChanges();
                return events;
            }
            catch (DbUpdateException dbUpdateException)
            {
                throw new Exception(dbUpdateException.InnerException?.Message ?? dbUpdateException.Message);
            }
        }
    }
}
