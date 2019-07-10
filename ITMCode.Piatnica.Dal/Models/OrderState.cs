using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;



namespace Piatnica.Dal.Models
{
   public  class OrderState 
    {
        
        public int id { get; set; }
        public string state { get; set; }
        public DateTime date { get; set; }

       public virtual Order order { get; set; }

    }
}