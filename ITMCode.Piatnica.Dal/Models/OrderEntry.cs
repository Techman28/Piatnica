using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace ITMCode.Piatnica.Dal.Models
{
    public class OrderEntry : IEntity
    {
        public OrderEntry() { }
        [Key]
        public string OrderType { get; set; }
        public string Location { get; set; }
        public TimeSpan Date { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
        public string Cargo { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }


        public virtual Order Order { get; set; }
        public ICollection<Delay> Delays { get; set; }
        public ICollection<EventHistory> EventHistories { get; set; }

        public int Id { get; set; }
    }
}