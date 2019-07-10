using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;



namespace Piatnica.Dal.Models
{
   public  class OrderState 
    {
        
        public int Id { get; set; }
        public string State { get; set; }
        public DateTime Date { get; set; }

        public virtual Order order { get; set; }

    }
}