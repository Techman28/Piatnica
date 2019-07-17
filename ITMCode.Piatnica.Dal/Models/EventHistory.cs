using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace ITMCode.Piatnica.Dal.Models
{
    public class EventHistory :IEntity
    {
        public EventHistory() { }
        public DateTime Date {get; set;}
        public double Distance { get; set; }
        public string Name { get; set;  }
        //public int eventId { get; set; }

        public virtual OrderEntry OrderEntry { get; set; }

        [Key]
        public int Id { get; set; }

    }
}