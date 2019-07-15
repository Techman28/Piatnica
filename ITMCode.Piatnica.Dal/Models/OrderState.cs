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
        public string state { get; set; }
        public DateTime date { get; set; }

       public virtual Order order { get; set; }

        public int Id { get; set; }

    }
}