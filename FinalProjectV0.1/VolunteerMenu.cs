using Android.App;
using Android.OS;
using Android.Runtime;
using AndroidX.AppCompat.App;
using Android.Widget;
using Android.Content;
using System;
using Android.Icu.Util;
using System.IO;

namespace FinalProjectV0._1
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class VolunteerMenu : AppCompatActivity
    {
        bool isRegistered = false;
        Button btnMoveToTimeTable, btnMoveToSessionNotes, btnMoveToManagerPage;
        protected override void OnCreate(Bundle savedInstanceState)
        {  
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.VolunteerMenu);
            isRegistered = CheckIfRegistered();
            if (!isRegistered)
            {
                Intent register = new Intent(this, typeof(RegisterPagesActivity));
                
                StartActivity(register);
            }
            btnMoveToTimeTable = FindViewById<Button>(Resource.Id.btnMoveToTimeTable);
            btnMoveToSessionNotes = FindViewById<Button>(Resource.Id.btnMoveToSessionNotes);
            btnMoveToManagerPage = FindViewById<Button>(Resource.Id.btnMoveToManagerPage);


            btnMoveToTimeTable.Click += BtnMoveToTimeTable_Click;
            btnMoveToSessionNotes.Click += BtnMoveToSessionNotes_Click;
            btnMoveToManagerPage.Click += BtnMoveToManagerPage_Click;


        }

        private void BtnMoveToManagerPage_Click(object sender, EventArgs e)
        {
            if (CheckIfRegistered())
            {
                Toast.MakeText(this, "Loading", ToastLength.Short).Show();
                Intent intent = new Intent(this, typeof(ManagerPageActivity));
                StartActivity(intent);
            }
            else
            {
                Toast.MakeText(this, "Access Denied", ToastLength.Short).Show();
            }
        }

        private bool CheckIfRegistered()
        {
            string fileContent;
            try
            {
                using (Stream inTo = OpenFileInput("isRegistered.txt"))
                {
                    try
                    {
                        byte[] buffer = new byte[4096];
                        inTo.Read(buffer, 0, buffer.Length);
                        Toast.MakeText(this, "Checking If Registered", ToastLength.Long).Show();
                        fileContent = System.Text.Encoding.Default.GetString(buffer);
                        inTo.Close();
                        if(fileContent != null)
                        {
                            Toast.MakeText(this, fileContent, ToastLength.Long).Show();
                        }
                        else
                        {
                            Toast.MakeText(this, "File Content Null", ToastLength.Long).Show();
                        }
                        return true;
                    }
                    catch
                    {
                        Console.WriteLine("read inner try error");
                        return false;
                    }
                    }
            }
            catch
            {
                Console.WriteLine("Read Outer Try Error");
            }
            return false;
        }

        private void BtnMoveToSessionNotes_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "Loading", ToastLength.Short).Show();
            Intent intent = new Intent(this, typeof(NotesActivity));
            StartActivity(intent);
        }

        private void BtnMoveToTimeTable_Click(object sender, System.EventArgs e)
        {
            Toast.MakeText(this, "Loading", ToastLength.Short).Show();
            Intent intent = new Intent(this, typeof(TimeTableActivity));
            StartActivity(intent);
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}