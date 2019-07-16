using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.Models
{
    public class EventHistoryApiModel
    {
        public TimeSpan Date { get; set; }
        public float Distance { get; set; }
        public int Id { get; set; }
    }
}
