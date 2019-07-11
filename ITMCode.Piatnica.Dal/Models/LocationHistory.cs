using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ITMCode.Piatnica.Dal.Models
{
   public class LocationHistory 
    {
        public int id { get; set; }
        public double longitude { get; set; }
        public double latitudeL { get; set; }
        public DateTime date { get; set; }

        public virtual Order order { get; set; }

    }
}