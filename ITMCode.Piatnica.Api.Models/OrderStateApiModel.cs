using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.Models
{
    public class OrderStateApiModel
    {
        public string State { get; set; }
        public DateTime Date { get; set; }

        public int Id { get; set; }
    }
}
