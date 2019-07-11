using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal;
using Microsoft.EntityFrameworkCore;

namespace Piatnica.Dal.Repository
{
    public class OrderRepository : IOrderRepository
    {
        private readonly PiatnicaContext _context;
        public OrderRepository() { }
        public OrderRepository(PiatnicaContext context)
        {
            _context = context;
        }
        public IEnumerable<Order> GetAll()
        {
            return _context.OrdersContext.ToList();
        }
        public Order GetById(int orderId)
        {
            return _context.OrdersContext.Find(orderId);
        }
        public void Insert(Order order)
        {
            _context.OrdersContext.Add(order);
        }
        public void Update(Order order)
        {
            _context.Entry(order).State = EntityState.Modified;
        }
        public void Delete(int orderId)
        {
            Order order = _context.OrdersContext.Find(orderId);
            _context.OrdersContext.Remove(order);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}