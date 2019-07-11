using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ITMCode.Piatnica.Dal.Models
{
    public class DistanceHistory 
    {
        public int id { get; set; }
        public double distance { get; set; }
        public DateTime date { get; set; }

        public virtual Event Event { get; set; }
        public virtual Order order { get; set; }
    }
}