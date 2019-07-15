using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace ITMCode.Piatnica.Dal.Models
{
    public class Order : IEntity
    {
        public Order() { }
        [Key]
        public int Id { get; set; }
        public string number { get; set; }

        public ICollection<OrderState> orderState { get; set; }
        public ICollection<LocationHistory> locationHistories { get; set; }
        public ICollection<DistanceHistory> distanceHistories { get; set; }
        public ICollection<OrderEntry> orderEntries { get; set; }

     }
}