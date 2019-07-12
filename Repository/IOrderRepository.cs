using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ITMCode.Piatnica.Dal.Models;

namespace ITMCode.Piatnica.Dal.Repository
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAll();
        Order GetById(int orderId);
        void Insert(Order order);
        void Update(Order order);
        void Delete(int orderId);
        void Save();
    }
}