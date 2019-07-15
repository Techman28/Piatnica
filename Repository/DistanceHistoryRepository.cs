using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal;
using Microsoft.EntityFrameworkCore;

namespace ITMCode.Piatnica.Dal.Repository
{
    public class DistanceHistoryRepository : IDistanceHistoryRepository
    {
        private readonly PiatnicaContext _context;
        public DistanceHistoryRepository() { }
        public DistanceHistoryRepository(PiatnicaContext context)
        {
            _context = context;
        }
        public IEnumerable<DistanceHistory> GetAll()
        {
            return _context.DistancesHistoryContext.ToList();
        }
        public DistanceHistory GetById(int distanceHistoryID)
        {
            return _context.DistancesHistoryContext.Find(distanceHistoryID);
        }
        public void Insert(DistanceHistory distanceHistory)
        {
            _context.DistancesHistoryContext.Add(distanceHistory);
        }
        public void Update(DistanceHistory distanceHistory)
        {
            _context.Entry(distanceHistory).State = EntityState.Modified;
        }
        public void Delete(int distanceHistoryID)
        {
            DistanceHistory distanceHistory = _context.DistancesHistoryContext.Find(distanceHistoryID);
            _context.DistancesHistoryContext.Remove(distanceHistory);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}