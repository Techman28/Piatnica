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
    public class LocationHistoryRepository : ILocationHistoryRepository
    {
        private readonly PiatnicaContext _context;
        public LocationHistoryRepository() { }
        public LocationHistoryRepository(PiatnicaContext context)
        {
            _context = context;
        }
        public IEnumerable<LocationHistory> GetAll()
        {
            return _context.LocationsHistoriesContext.ToList();
        }
        public LocationHistory GetById(int locationHistoryId)
        {
            return _context.LocationsHistoriesContext.Find(locationHistoryId);
        }
        public void Insert(LocationHistory eventO)
        {
            _context.LocationsHistoriesContext.Add(eventO);
        }
        public void Update(LocationHistory eventO)
        {
            _context.Entry(eventO).State = EntityState.Modified;
        }
        public void Delete(int locationHistoryId)
        {
            LocationHistory eventO = _context.LocationsHistoriesContext.Find(locationHistoryId);
            _context.LocationsHistoriesContext.Remove(eventO);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}