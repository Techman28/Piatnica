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
    public class DelayRepository : IDelayRepository
    {
        private readonly PiatnicaContext _context;
        public DelayRepository() { }
        public DelayRepository(PiatnicaContext context)
        {
            _context = context;
        }
        public IEnumerable<Delay> GetAll()
        {
            return _context.DelaysContext.ToList();
        }
        public Delay GetById(int delayID)
        {
            return _context.DelaysContext.Find(delayID);
        }
        public void Insert(Delay delay)
        {
            _context.DelaysContext.Add(delay);
        }
        public void Update(Delay delay)
        {
            _context.Entry(delay).State = EntityState.Modified;
        }
        public void Delete(int delayID)
        {
            Delay delay = _context.DelaysContext.Find(delayID);
            _context.DelaysContext.Remove(delay);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}