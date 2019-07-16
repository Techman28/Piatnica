using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace ITMCode.Piatnica.Dal.Models
{
   public class LocationHistory : IEntity
    {
        public LocationHistory() { }

        [Key]
        public double Longitude { get; set; }
        public double LatitudeL { get; set; }
        public TimeSpan Date { get; set; }

        public virtual Order Order { get; set; }

        public int Id { get; set; }

    }
}