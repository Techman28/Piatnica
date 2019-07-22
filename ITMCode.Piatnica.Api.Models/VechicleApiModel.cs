using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.Models
{
    public class VechicleApiModel
    {
        public VechicleApiModel() { }

        public string Brand { get; set; }
        public string Registration { get; set; }
        public int Mileage { get; set; }
        public int Capacity { get; set; }

    }
}
