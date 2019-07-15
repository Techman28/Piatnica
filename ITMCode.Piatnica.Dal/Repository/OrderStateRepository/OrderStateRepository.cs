using ITMCode.Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Dal.Repository.OrderStateRepository

{
   public class OrderStateRepository : BaseRepository<OrderState>, IOrderStateRepository
    {
        public OrderStateRepository(PiatnicaContext context) : base(context)
        {

        }

    }
}
