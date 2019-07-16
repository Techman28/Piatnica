using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class DelayDto : IValidatable
    {
        public int DelayOrder { get; set; }
        public TimeSpan Date { get; set; }
    }
}
