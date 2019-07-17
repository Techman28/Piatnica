using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class EventHistoryDto
    {
        public DateTime Date { get; set; }
        public float Distance { get; set; }
        public string Name { get; set; }
        //public int eventId { get; set; }
    }
}
