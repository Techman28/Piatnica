using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Piatnica.Dal.Models
{
    public class EventHistory 
    {
        public int id { get; set; }
        public DateTime date {get; set;}

        //public int eventId { get; set; }

        public virtual Event Event { get; set; }
        public virtual OrderEntry OrderEntry { get; set; }
    }
}