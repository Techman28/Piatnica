using ITMCode.Piatnica.Dal.Models;
using ITMCode.Piatnica.Dal.Repository.OrderEntryRepository;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.OrderEntryRepository

{
   public class OrderEntryRepository : BaseRepository<OrderEntry>, IOrderEntryRepository
    {
        public OrderEntryRepository(PiatnicaContext context) : base(context)
        {

        }

    }
}
