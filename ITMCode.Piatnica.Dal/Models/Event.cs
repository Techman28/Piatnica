using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ITMCode.Piatnica.Dal.Models
{
    public class Event 
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }


        public ICollection<EventHistory> EventHistories { get; set; }
        public ICollection<DistanceHistory> DistanceHistories { get; set; }
        
    }
}