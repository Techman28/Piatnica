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
using ITMCode.Piatnica.Dal;
using ITMCode.Piatnica.Dal.Repository;
using ITMCode.Piatnica.Dal.UnitOfWork;
//using ITMCode.Piatnica.Dal.Controllers;
using ITMCode.Piatnica.Dal.Models;
using Microsoft.EntityFrameworkCore;
//using System.Threading.Tasks;

namespace Piatnica
{
    [Activity(Label = "@string/app_name", Theme = "@style/MyTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.login);

            Toolbar toolbar = FindViewById<Toolbar>(Resource.Id.toolbar);
            SetActionBar(toolbar);

            Button login = FindViewById<Button>(Resource.Id.loginButton);
            login.Click += delegate
            {
                loginClicked();
            };
            //FloatingActionButton fab = FindViewById<FloatingActionButton>(Resource.Id.fab);
            //fab.Click += FabOnClick;
            var _dbFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var _fileName = "Piatnica.db";
            var _dbFullPath = Path.Combine(_dbFolder, _fileName);
            //GenericUnitOfWork Uof;
            //var db = new PiatnicaContext(_dbFullPath);
            try
            {
                using (PiatnicaContext db = new PiatnicaContext(_dbFullPath))
                {


                    await db.Database.MigrateAsync(); //We need to ensure the latest Migration was added. This is different than EnsureDatabaseCreated.
                    //Uof = new GenericUnitOfWork(db);
                    //await Initialize(Uof);

                    //var check = await db.Set<Order>().ToListAsync();

                }

            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.ToString());
            }

            //var dbFolder =Get
            //  var dd = new PiatnicaContext();
        }

        /*private async Task Initialize(GenericUnitOfWork Uof)
        {
            //if (await uof.Set<Order>().AnyAsync())
              //  return;

            for (int i = 0; i < 10; i++)
            {
                //db.Set<Order>().Add(new Order() { number = "fghfg" });
                
            }
            Uof.GetRepoInstance<Order>().Insert(new Order() { number ="num"});
            var check = Uof.GetRepoInstance<Order>().GetAll();
            //EventRepository eventRepository = new EventRepository();
            //eventRepository.Insert(new Event() { name = "Załadunek" });

            await Uof.saveAsync();
        }*/

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.menu_main, menu);
            return true;
        }
        private void loginClicked()
        {
            StartActivity(typeof(orderListActivity));
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
            View view = (View)sender;
            Snackbar.Make(view, "Replace with your own action", Snackbar.LengthLong)
                .SetAction("Action", (Android.Views.View.IOnClickListener)null).Show();
        }
    }
}

