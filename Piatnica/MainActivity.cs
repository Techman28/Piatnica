using System;
using System.Collections.Generic;
using System.IO;
using Android.App;
using Android.OS;
using Android.Runtime;
using Android.Support.Design.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Piatnica.Dal;
using Piatnica.Dal.Models;
using Microsoft.EntityFrameworkCore;

namespace Piatnica
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_main);

            Android.Support.V7.Widget.Toolbar toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);

            FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            fab.Click += FabOnClick;
            var _dbFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var _fileName = "Piatnica.db";
            var _dbFullPath = Path.Combine(_dbFolder, _fileName);
            //var db = new PiatnicaContext(dbFullPath);
            try
            {
                using (var db = new PiatnicaContext(_dbFullPath))
                {
                     
                    await db.Database.MigrateAsync(); //We need to ensure the latest Migration was added. This is different than EnsureDatabaseCreated.

                    //Delay catGary = new Delay() { 1 , 1, "2019-12-12" };
                    

                    //List catsInTheHat = new List() { catGary, catJack, catLuna };
                    ///asdsadsadasdsadsadsad

                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }
        
        //var dbFolder =Get
        //  var dd = new PiatnicaContext();
    }
        
        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }
        
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            int id = item.ItemId;
            if (id == Resource.Id.action_settings)
            {
                return true;
            }

            return base.OnOptionsItemSelected(item);
        }

        private void FabOnClick(object sender, EventArgs eventArgs)
        {
            View view = (View) sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
	}
}

