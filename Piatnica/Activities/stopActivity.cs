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

namespace Piatnica.Activities
{
    [Activity]
    class stopActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.eventTypeActivity);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);

            Button destination = FindViewById<Button>(Resource.Id.destination);
            destination.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(delayActivity));
                StartActivity(intent);
            };
            Button breakButton = FindViewById<Button>(Resource.Id.breakBtn);
            breakButton.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(delayActivity));
                StartActivity(intent);
            };
            Button fuelBtn = FindViewById<Button>(Resource.Id.fueling);
            fuelBtn.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(delayActivity));
                StartActivity(intent);
            };
        }
    }
}