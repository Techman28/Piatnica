using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;



namespace ITMCode.Piatnica.Dal.Models
{
   public  class OrderState : IEntity
    {
        public OrderState() { }

        [Key]
        public string State { get; set; }
        public DateTime Date { get; set; }

       public virtual Order Order { get; set; }

        public int Id { get; set; }

    }
}