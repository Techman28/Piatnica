using Piatnica.Dal.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;



namespace Piatnica.Dal.Repository
{
    public class DelayRepository
    {
        public DelayRepository() { }
        public void addDelay(int id, int delayOrder, String date)
        {
            DateTime dt = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            Delay delay = new Delay() { id= id, delayOrder= delayOrder, date=dt };

        }
    }
}