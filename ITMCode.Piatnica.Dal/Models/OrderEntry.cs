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
        public string OrderType { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string Cargo { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }


        public virtual Order Order { get; set; }
        public ICollection<Delay> Delays { get; set; }
        public ICollection<EventHistory> EventHistories { get; set; }



        [Key]
        public int Id { get; set; }
    }
}