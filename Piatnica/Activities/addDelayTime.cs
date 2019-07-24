using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics.Drawables;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;
using static Android.Widget.TextView;

namespace Piatnica.Activities
{
    [Activity]
    class addDelayTime:Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.addingDelay);

            Android.Widget.Toolbar toolbar = FindViewById<Android.Widget.Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);

            Button confirm = FindViewById<Button>(Resource.Id.confirm);
            CardView cardView = FindViewById<CardView>(Resource.Id.cardView1);
            confirm.Click += (object sender, EventArgs e) =>
            {
                var intent = new Intent(this, typeof(detailsActivity));
                StartActivity(intent);
                var color = "#F28C00";
                cardView.SetBackgroundColor(Android.Graphics.Color.ParseColor(color));
                Finish();
            };
            calculatorLogic();
            
        }
        private void calculatorLogic()
        {
            TextView summary= FindViewById<TextView>(Resource.Id.delayText);
            var delaySum = 0;
            Button add10 = FindViewById<Button>(Resource.Id.add10);
            add10.Click += (object sender, EventArgs e) =>
            {
                delaySum += 10;
                summary.Text = delaySum.ToString();

            };
            Button add20 = FindViewById<Button>(Resource.Id.add20);
            add20.Click += (object sender, EventArgs e) =>
            {
                delaySum += 20;
                summary.Text = delaySum.ToString();

            };
            Button add30 = FindViewById<Button>(Resource.Id.add30);
            add30.Click += (object sender, EventArgs e) =>
            {
                delaySum += 30;
                summary.Text = delaySum.ToString();
            };
            Button add40 = FindViewById<Button>(Resource.Id.add40);
            add40.Click += (object sender, EventArgs e) =>
            {
                delaySum += 40;
                summary.Text = delaySum.ToString();
            };
            Button add50 = FindViewById<Button>(Resource.Id.add50);
            add50.Click += (object sender, EventArgs e) =>
            {
                delaySum += 50;
                summary.Text = delaySum.ToString();
            };
            Button add60 = FindViewById<Button>(Resource.Id.add60);
            add60.Click += (object sender, EventArgs e) =>
            {
                delaySum += 60;
                summary.Text = delaySum.ToString();
            };
            Button add70 = FindViewById<Button>(Resource.Id.add70);
            add70.Click += (object sender, EventArgs e) =>
            {
                delaySum += 70;
                summary.Text = delaySum.ToString();
            };
            Button add80 = FindViewById<Button>(Resource.Id.add80);
            add80.Click += (object sender, EventArgs e) =>
            {
                delaySum += 80;
                summary.Text = delaySum.ToString();
            };
            Button add90 = FindViewById<Button>(Resource.Id.add90);
            add90.Click += (object sender, EventArgs e) =>
            {
                delaySum += 90;
                summary.Text = delaySum.ToString();
            };
            Button clear = FindViewById<Button>(Resource.Id.resetBtn);
            clear.Click += (object sender, EventArgs e) =>
            {                
                
                summary.Text=" ";
                delaySum = 0;

            };
        }

    }
}
