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
    public class orderListActivity :  Activity
    {
        private List<OrderEntry> _commisions;
        private ListView _list;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.commissions);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);

            _commisions = new List<OrderEntry>();
            _list = FindViewById<ListView>(Resource.Id.commisionList);
            _commisions.Add(new OrderEntry() { OrderType = "Zaladunek", Location = "dupa" });
            _commisions.Add(new OrderEntry() { OrderType = "hehe", Location = "Dom Piotrka" });

            commisionsListAdapter adapter = new commisionsListAdapter(this, _commisions);
            _list.Adapter= adapter;
            _list.ItemClick += listItemClicked;
            
        }
        private void listItemClicked(object sender, ItemClickEventArgs e)
        {
            var intent = new Intent(this, typeof(detailsActivity));
            StartActivity(intent);
        }

    }
}