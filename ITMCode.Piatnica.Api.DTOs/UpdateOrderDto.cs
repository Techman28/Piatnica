using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.DTOs
{
   public class UpdateOrderDto : IValidatable
    {
        public string Number { get; set; }

        public ICollection<OrderStateDto> OrderState { get; set; }
        public ICollection<LocationHistoryDto> LocationHistories { get; set; }
        public ICollection<OrderEntryDto> OrderEntries { get; set; }
    }
}
