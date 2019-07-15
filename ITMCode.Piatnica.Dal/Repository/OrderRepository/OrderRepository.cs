using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.Repository.OrderEntryRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.OrderRepository

{
   public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        public OrderRepository(PiatnicaContext context) : base(context)
        {

        }

    }
}
