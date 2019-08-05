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
using ITMCode.Piatnica.Dal.Models;


namespace Piatnica.Activities
{
    
    public class commisionsListAdapter : BaseAdapter<string>
    {
        public List<OrderEntry> _commisionsList;
        private Context _context;
        public commisionsListAdapter(Context context, List<OrderEntry> items)
        {
            _commisionsList = items;
            _context = context;
        }
        public override string this[int position] => throw new NotImplementedException();

        public override int Count
        {
            get { return _commisionsList.Count(); }
        }

        public override long GetItemId(int position)
        {

            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
                row = LayoutInflater.From(_context).Inflate(Resource.Layout.commisonListRow, null, false);
            TextView type = row.FindViewById<TextView>(Resource.Id.type);
            type.Text = _commisionsList[position].OrderType;

            TextView location = row.FindViewById<TextView>(Resource.Id.location);
            location.Text = _commisionsList[position].Location;
            return row;
        }
    }
}