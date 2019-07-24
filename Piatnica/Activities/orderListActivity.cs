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

            var loc = "Lokazliacja: ";
            _commisions = new List<OrderEntry>();
            _list = FindViewById<ListView>(Resource.Id.commisionList);
            _commisions.Add(new OrderEntry() { OrderType = "Załadunek", Location = loc + "Kielce,Karola Olszewskiego 6" });
            _commisions.Add(new OrderEntry() { OrderType = "Rozładunek", Location = loc + "Kielce,Karola Olszewskiego 6" });
            _commisions.Add(new OrderEntry() { OrderType = "Załadunek", Location = loc + "Warszawska 26" });
            _commisions.Add(new OrderEntry() { OrderType = "Rozładunek", Location = loc + "Warszawska 26" });
            _commisions.Add(new OrderEntry() { OrderType = "Załadunek", Location = loc + "Żniwna 14" });
            _commisions.Add(new OrderEntry() { OrderType = "Rozładunek", Location = loc + "Żniwna 14" });
            _commisions.Add(new OrderEntry() { OrderType = "Załadunek", Location = loc + "Chęcińska 38" });
            _commisions.Add(new OrderEntry() { OrderType = "Rozładunek", Location = loc + "Chęcińska 38" });

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