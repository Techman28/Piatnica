using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.Models
{
   public class OrderApiModel
    {
        public string Number { get; set; }

        public ICollection<OrderStateApiModel> OrderState { get; set; }
        public ICollection<LocationHistoryApiModel> LocationHistories { get; set; }
        public ICollection<OrderEntryApiModel> OrderEntries { get; set; }
    }
}
