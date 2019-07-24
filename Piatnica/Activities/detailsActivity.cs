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
        
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.detailsActivity);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);


        }


    }
}