using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Piatnica.Dal.Models
{
    public class Order 
    {
        public Order() { }
        public int id { get; set; }
        public string number { get; set; }

        public ICollection<OrderState> orderState { get; set; }
        public ICollection<LocationHistory> locationHistories { get; set; }
        public ICollection<DistanceHistory> distanceHistories { get; set; }
        public ICollection<OrderEntry> orderEntries { get; set; }

    }
}