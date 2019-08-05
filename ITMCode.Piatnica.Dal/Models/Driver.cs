using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;



namespace ITMCode.Piatnica.Dal.Models
{
    public class Driver : IEntity
    {
        public Driver() { }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string DriverLicense{ get; set; }
        public DateTime HiringDate { get; set; }
        public ICollection<Order> Orders { get; set; }
        [Key]
        public int Id { get; set; }
    }
}