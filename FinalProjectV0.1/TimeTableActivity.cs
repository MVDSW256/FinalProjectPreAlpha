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
    [Activity(Label = "TimeTableActivity")]
    public class TimeTableActivity : Activity
    {
        Button btnMoveToEditTime, btnMoveToTimeTable, btnChangeDate;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.timeTable);
            btnMoveToEditTime = FindViewById<Button>(Resource.Id.btnMoveToEditTime);
            //btnMoveToTimeTable = FindViewById<Button>(Resource.Id.btnMoveToTimeTable);
            btnChangeDate = FindViewById<Button>(Resource.Id.btnChangeDate);


            btnMoveToEditTime.Click += BtnMoveToEditTime_Click;
            //btnMoveToTimeTable.Click += BtnMoveToTimeTable_Click1;
            btnChangeDate.Click += BtnChangeDate_Click;

        }

        /* private void BtnMoveToTimeTable_Click1(object sender, EventArgs e)
         {
             Toast.MakeText(this, "Loading", ToastLength.Short).Show();
             Intent intent = new Intent(this, typeof(VolunteerMenu));
             StartActivity(intent);
         }*/

        private void BtnChangeDate_Click(object sender, EventArgs e)
        {
            Dialog d = new Dialog(this);
            d.SetContentView(Resource.Layout.TempDatePicker);
            d.SetTitle("Date Picker");
            d.SetCancelable(true);
            d.Show();
        }

        private void BtnMoveToEditTime_Click(object sender, System.EventArgs e)
            {
            Toast.MakeText(this, "This is yet to be built", ToastLength.Short).Show();
            //Intent intent = new Intent(this, typeof(EditTimeTableActivity));
            //StartActivity(intent);
            }

        //public override void OnActivityResult()
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        }
    }