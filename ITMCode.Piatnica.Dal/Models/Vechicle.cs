using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace ITMCode.Piatnica.Dal.Models
{
    public class Vechicle : IEntity
    {
        public Vechicle() { }
        
        public string Brand { get; set; }
        public string Registration { get; set; }
        public int Mileage { get; set; }
        public int Capacity { get; set; }

        public ICollection<Order> Orders { get; set; }
        [Key]
        public int Id { get; set; }
    }
}
