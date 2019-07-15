using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Bll.Models
{
    public  class OrderBllModel
    {
        
         public int Id { get; set; }
        public string Number { get; set; }

        public ICollection<OrderStateBllModel> OrderState { get; set; }
        public ICollection<LocationHistoryBllModel> LocationHistories { get; set; }
        public ICollection<OrderEntryBllModel> OrderEntries { get; set; }
    }
}
