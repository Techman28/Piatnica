using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Piatnica.Dal.Models;

namespace Piatnica.Dal.Repository
{
    public interface IOrderEntryRepository
    {
        IEnumerable<OrderEntry> GetAll();
        OrderEntry GetById(int orderEntryId);
        void Insert(OrderEntry orderEntry);
        void Update(OrderEntry orderEntry);
        void Delete(int orderEntryId);
        void Save();
    }
}