using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.DTOs
{
  public  class LocationHistoryDto : IValidatable
    {
        public double Longitude { get; set; }
        public double LatitudeL { get; set; }
        public TimeSpan Date { get; set; }
    }
}
