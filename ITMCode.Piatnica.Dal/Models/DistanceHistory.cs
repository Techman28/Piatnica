using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ITMCode.Piatnica.Dal.Models
{
    public class DistanceHistory : IEntity
    {
        public DistanceHistory() { }

        [Key]
        public double distance { get; set; }
        public DateTime date { get; set; }

        //public virtual Event Event { get; set; }
        public virtual Order order { get; set; }

        public int Id { get; set; }
    }
}