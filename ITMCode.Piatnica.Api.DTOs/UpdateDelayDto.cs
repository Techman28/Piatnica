using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class UpdateDelayDto : IValidatable
    {
        public int DelayOrder { get; set; }
        public DateTime Date { get; set; }
    }
}
