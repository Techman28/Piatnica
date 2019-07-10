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
    public class OrderEntryRepository : IOrderEntryRepository
    {
        private readonly PiatnicaContext _context;
        public OrderEntryRepository() { }
        public OrderEntryRepository(PiatnicaContext context)
        {
            _context = context;
        }
        public IEnumerable<OrderEntry> GetAll()
        {
            return _context.OrdersEntriesContext.ToList();
        }
        public OrderEntry GetById(int orderEntryId)
        {
            return _context.OrdersEntriesContext.Find(orderEntryId);
        }
        public void Insert(OrderEntry orderEntry)
        {
            _context.OrdersEntriesContext.Add(orderEntry);
        }
        public void Update(OrderEntry orderEntry)
        {
            _context.Entry(orderEntry).State = EntityState.Modified;
        }
        public void Delete(int orderEntryId)
        {
            OrderEntry orderEntry = _context.OrdersEntriesContext.Find(orderEntryId);
            _context.OrdersEntriesContext.Remove(orderEntry);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}