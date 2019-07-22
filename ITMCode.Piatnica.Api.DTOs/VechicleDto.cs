using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class VechicleDto : IValidatable
    {
        public string Brand { get; set; }
        public string Registration { get; set; }
        public int Mileage { get; set; }
        public int Capacity { get; set; }
    }
}
