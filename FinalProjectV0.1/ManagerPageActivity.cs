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
    [Activity(Label = "ManagerPageActivity")]
    public class ManagerPageActivity : Activity
    {
        Button BtnMoveToVolunteerMenu;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.ManagerPage);

            BtnMoveToVolunteerMenu = FindViewById<Button>(Resource.Id.btnMoveToVolunteerMenu);

            BtnMoveToVolunteerMenu.Click += BtnMoveToVolunteerTimeTable_Click;
        }

        private void BtnMoveToVolunteerTimeTable_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Loading", ToastLength.Short).Show();
            Intent intent = new Intent(this, typeof(VolunteerMenu));
            StartActivity(intent);
        }
    }
}