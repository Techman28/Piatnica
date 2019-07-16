﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.Models
{
    public class OrderEntryApiModel
    {
        public string OrderType { get; set; }
        public string Location { get; set; }
        public TimeSpan Date { get; set; }
        public TimeSpan FromTime { get; set; }
        public TimeSpan ToTime { get; set; }
        public string Cargo { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }
        public int Id { get; set; }
    }
}
