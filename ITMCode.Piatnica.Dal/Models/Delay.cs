using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;



namespace ITMCode.Piatnica.Dal.Models
{
    public class Delay 
    {
        public Delay() {  }
        [Key]
        public int id { get; set; }
        public int delayOrder { get; set; }
        public DateTime date { get; set; }

        public virtual OrderEntry OrderEntry { get; set; }
    }
}