using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Bll.Models
{
    public  class OrderEntryBllModel
    {
        public string OrderType { get; set; }
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public string Cargo { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }
        public int Id { get; set; }
    }
}
