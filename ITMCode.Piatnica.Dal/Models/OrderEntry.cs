using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ITMCode.Piatnica.Dal.Models
{
    public class OrderEntry
    {
        public int Id { get; set; }
        public string orderType { get; set; }
        public string location { get; set; }
        public DateTime date { get; set; }
        public DateTime fromTime { get; set; }
        public DateTime toTime { get; set; }
        public string cargo { get; set; }
        public string comments { get; set; }
        public int status { get; set; }


        public virtual Order order { get; set; }
        public ICollection<Delay> delays { get; set; }
        public ICollection<EventHistory> eventHistories { get; set; }

    }
}