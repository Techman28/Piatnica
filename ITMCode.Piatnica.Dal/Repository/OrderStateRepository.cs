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
    public class OrderStateRepository : IOrderStateRepository
    {
        private readonly PiatnicaContext _context;
        public OrderStateRepository() { }
        public OrderStateRepository(PiatnicaContext context)
        {
            _context = context;
        }
        public IEnumerable<OrderState> GetAll()
        {
            return _context.OrdersStatesContext.ToList();
        }
        public OrderState GetById(int orderStateId)
        {
            return _context.OrdersStatesContext.Find(orderStateId);
        }
        public void Insert(OrderState orderState)
        {
            _context.OrdersStatesContext.Add(orderState);
            
        }
        public void Update(OrderState orderState)
        {
            _context.Entry(orderState).State = EntityState.Modified;
        }
        public void Delete(int orderStateId)
        {
            OrderState orderState = _context.OrdersStatesContext.Find(orderStateId);
            _context.OrdersStatesContext.Remove(orderState);
        }
        public void Save()
        {
            _context.SaveChanges();
        }
    }
}