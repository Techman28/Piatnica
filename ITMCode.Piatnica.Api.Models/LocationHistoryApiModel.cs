using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.Models
{
    public class LocationHistoryApiModel
    {
        public double Longitude { get; set; }
        public double LatitudeL { get; set; }
        public TimeSpan Date { get; set; }

        public int Id { get; set; }
    }
}
