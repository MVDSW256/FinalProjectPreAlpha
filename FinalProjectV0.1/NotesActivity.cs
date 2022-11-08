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

namespace FinalProjectV0._1
{
    [Activity(Label = "Activity1")]
    public class NotesActivity : Activity
    {
        Button BtnMoveToRegularVolunteerMenu;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.notesOnSession);

            BtnMoveToRegularVolunteerMenu = FindViewById<Button>(Resource.Id.btnMoveToRegularVolunteerMenu);

            BtnMoveToRegularVolunteerMenu.Click += BtnMoveToRegularVolunteerTimeTable_Click;
        }

        private void BtnMoveToRegularVolunteerTimeTable_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Loading", ToastLength.Short).Show();
            Intent intent = new Intent(this, typeof(VolunteerMenu));
            StartActivity(intent);
        }
    }
}