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
    class delayActivity:Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.delayActivity);

            Android.Widget.Toolbar toolbar = FindViewById<Android.Widget.Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);
            this.ActionBar.Title = "";
            Button confirm = FindViewById<Button>(Resource.Id.confirmDelay);           
            confirm.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(detailsActivity));
                StartActivity(intent);
                Finish();
            };
            ImageButton cameraBtn = FindViewById<ImageButton>(Resource.Id.camera);
            cameraBtn.Click += (object sender, EventArgs e) =>
            {

            };



        }
    }
}