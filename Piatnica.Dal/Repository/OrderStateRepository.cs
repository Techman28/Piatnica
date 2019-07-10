using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Piatnica.Dal.Models;

namespace Piatnica.Dal.Repository
{
   public class OrderStateRepository
    {
        public OrderStateRepository() { }
        public void addorderState(int id, string state, String date)
        {
            DateTime dt = DateTime.ParseExact(date, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            OrderState orderState = new OrderState() { id = id, state = state, date = dt};

        }
    }
}