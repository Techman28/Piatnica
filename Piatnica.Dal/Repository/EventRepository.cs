using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using Piatnica.Dal.Models;
using Piatnica.Dal;
using Microsoft.EntityFrameworkCore;

namespace Piatnica.Dal.Repository
{
    public class EventRepository : IEventRepository
    {
        private readonly PiatnicaContext _context;
        public EventRepository() { }
        public EventRepository(PiatnicaContext context)
        {
            _context = context;
        }
        public IEnumerable<Event> GetAll()
        {
            return _context.EventsContext.ToList();
        }
        public Event GetById(int eventID)
        {
            return _context.EventsContext.Find(eventID);
        }
        public void Insert(Event eventO)
        {
            _context.EventsContext.Add(eventO);
        }
        public void Update(Event eventO)
        {
            _context.Entry(eventO).State = EntityState.Modified;
        }
        public void Delete(int eventId)
        {
            Event eventO = _context.EventsContext.Find(eventId);
            _context.EventsContext.Remove(eventO);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}