﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ITMCode.Piatnica.Api.DTOs
{
    public class AddEventHistoryDto : IValidatable
    {
        public DateTime Date { get; set; }
        public float Distance { get; set; }
        public string Name { get; set;  }
    }
}
