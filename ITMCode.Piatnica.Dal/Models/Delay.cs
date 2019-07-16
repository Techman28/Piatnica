using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;



namespace ITMCode.Piatnica.Dal.Models
{
    public class Delay : IEntity
    {
        public Delay() {  }
      
 
        public int DelayOrder { get; set; }
        public DateTime Date { get; set; }

        public virtual OrderEntry OrderEntry { get; set; }
        public int Id { get; set; }
    }
}