using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using ITMCode.Piatnica.Dal.Models;
using Piatnica.Activities;
using static Android.Widget.AdapterView;

namespace Piatnica.Activities
{
    [Activity]
    public class detailsActivity : Activity
    {
        public override void OnBackPressed()
        {
            //base.OnBackPressed();
        }
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.detailsActivity);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            this.ActionBar.Title = "";
            Button delay = FindViewById<Button>(Resource.Id.delayBtn);
            delay.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(addDelayTime));

                StartActivity(intent);
            };
            Button stop = FindViewById<Button>(Resource.Id.stop);
            stop.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(stopActivity));

                StartActivity(intent);
            };
        }
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back)
            {
                var intent = new Intent(this, typeof(orderListActivity));

                StartActivity(intent);
                return false;
            }

            return true;
        }

    }
}