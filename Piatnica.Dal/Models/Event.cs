using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace Piatnica.Dal.Models
{
    public class Event 
    {
        public int id { get; set; }
        public string name { get; set; }

        ICollection<EventHistory> EventHistories { get; set; }
        ICollection<DistanceHistory> DistanceHistories { get; set; }
        
    }
}