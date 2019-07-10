using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



namespace Piatnica.Dal.Models
{
    public class Delay 
    {
        public int id { get; set; }
        public int delayOrder { get; set; }
        public DateTime date { get; set; }
    }
}