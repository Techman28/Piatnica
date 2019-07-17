using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class UpdateOrderEntryDto : IValidatable
    {
        public UpdateOrderEntryDto() { }
        public string OrderType { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string Cargo { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }


        public ICollection<DelayDto> Delays { get; set; }
        public ICollection<EventHistoryDto> EventHistories { get; set; }
    }
}
