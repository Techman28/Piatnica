using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.Models
{
    public class DriverApiModel
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string DriverLicense { get; set; }
        public DateTime HiringDate { get; set; }
    }
}
