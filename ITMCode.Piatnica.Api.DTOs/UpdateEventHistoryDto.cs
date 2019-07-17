using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class UpdateEventHistoryDto : IValidatable
    {
        public DateTime Date { get; set; }
        public double Distance { get; set; }
        public string Name { get; set; }
    }
}
