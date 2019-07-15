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
        public double longitude { get; set; }
        public double latitudeL { get; set; }
        public DateTime date { get; set; }

        public virtual Order order { get; set; }

        public int Id { get; set; }

    }
}