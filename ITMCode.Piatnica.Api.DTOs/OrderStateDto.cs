using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class OrderStateDto : IValidatable
    {
        public string State { get; set; }
        public DateTime Date { get; set; }

    }
}
