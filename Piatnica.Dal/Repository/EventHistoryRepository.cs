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
    public class EventHistoryRepository : IEventHistoryRepository
    {
        private readonly PiatnicaContext _context;
        public EventHistoryRepository() { }
        public EventHistoryRepository(PiatnicaContext context)
        {
            _context = context;
        }
        public IEnumerable<EventHistory> GetAll()
        {
            return _context.EventsHistoriesContext.ToList();
        }
        public EventHistory GetById(int eventHistoryId)
        {
            return _context.EventsHistoriesContext.Find(eventHistoryId);
        }
        public void Insert(EventHistory eventHistory)
        {
            _context.EventsHistoriesContext.Add(eventHistory);
        }
        public void Update(EventHistory eventHistory)
        {
            _context.Entry(eventHistory).State = EntityState.Modified;
        }
        public void Delete(int eventHistoryId)
        {
            EventHistory eventHistory = _context.EventsHistoriesContext.Find(eventHistoryId);
            _context.EventsHistoriesContext.Remove(eventHistory);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}