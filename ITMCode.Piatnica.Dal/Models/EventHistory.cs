﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;


namespace ITMCode.Piatnica.Dal.Models
{
    public class EventHistory :IEntity
    {
        public EventHistory() { }
        [Key]
        public TimeSpan Date {get; set;}
        public float Distance { get; set; }
        //public int eventId { get; set; }

        public virtual OrderEntry OrderEntry { get; set; }

        public int Id { get; set; }

    }
}