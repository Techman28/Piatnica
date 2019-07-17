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

        public double Longitude { get; set; }
        public double LatitudeL { get; set; }
        public DateTime Date { get; set; }

        public virtual Order Order { get; set; }
        [Key]
        public int Id { get; set; }

    }
}