using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace ITMCode.Piatnica.Dal.Models
{
    public class Order : IEntity
    {
        public Order() { }


        [Key]
        public int Id { get; set; }
        public string Number { get; set; }

        public ICollection<OrderState> OrderState { get; set; }
        public ICollection<LocationHistory> LocationHistories { get; set; }
        public ICollection<OrderEntry> OrderEntries { get; set; }
        public virtual Vechicle Vechicle { get; set; }
        
        public virtual Driver Driver { get; set; }
    }
}