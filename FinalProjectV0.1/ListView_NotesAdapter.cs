using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;

namespace FinalProjectV0._1
{
    internal class ListView_NotesAdapter : BaseAdapter<SessionNote>
    {
        Android.Content.Context lvContext;
        List<SessionNote> objects;

        public ListView_NotesAdapter(Android.Content.Context c, List<SessionNote> l)
        {
            lvContext = c;
            objects = l;
        }

        public override SessionNote this[int position] => throw new NotImplementedException();

        public override int Count => throw new NotImplementedException();

        public override long GetItemId(int position)
        {
            return position;
        }

        public List<SessionNote> getList()
        {
            return objects;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            Android.Views.LayoutInflater layoutInflater = ((NotesActivity)lvContext).LayoutInflater;
            Android.Views.View view = layoutInflater.Inflate(Resource.Layout.ListviewLayout_Notes, parent, false);

            TextView Name = view.FindViewById<TextView>(Resource.Id.TVName);
            TextView title = view.FindViewById<TextView>(Resource.Id.title);
            TextView date = view.FindViewById<TextView>(Resource.Id.date);
            TextView group = view.FindViewById<TextView>(Resource.Id.group);

            SessionNote Temp = objects[position];

            if (Temp != null)
            {
                Name.Text = "Name: " + Temp.volunteerName + "   ";
                title.Text = "name: " + Temp.noteTitle + "   ";
                date.Text = "date: " + Temp.datePosted + "   ";
                group.Text = "group: " + Temp.group + "  ";
            }
            return view;
        }
        
    }
}