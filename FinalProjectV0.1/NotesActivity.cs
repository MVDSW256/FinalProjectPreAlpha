using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static AndroidX.RecyclerView.Widget.RecyclerView;

namespace FinalProjectV0._1
{
    [Activity(Label = "Activity1")]
    public class NotesActivity : Activity
    {
        Button BtnMoveToVolunteerMenu;
        ListView_NotesAdapter adapter;
        ListView listView;
        private object tempNotes;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.notesOnSession);
            BtnMoveToVolunteerMenu = FindViewById<Button>(Resource.Id.btnMoveToVolunteerMenu);
            BtnMoveToVolunteerMenu.Click += BtnMoveToVolunteerTimeTable_Click;



            //adapter = new ListView_NotesAdapter(this, tempNotes);
        }
        /*protected override void OnResume()
        {
            base.OnResume();
            if (adapter != null)
            {
                adapter.NotifyDataSetChanged();
            }
        }*/
        private void BtnMoveToVolunteerTimeTable_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Loading", ToastLength.Short).Show();
            Intent intent = new Intent(this, typeof(VolunteerMenu));
            StartActivity(intent);
        }
    }
}