using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static Android.Renderscripts.ScriptGroup;

namespace FinalProjectV0._1
{
    [Activity(Label = "RegisterPageActivity")]
    public class RegisterPageActivity : Activity
    {
        Button register, registerAdmin;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.TempRegisterPage);
            // Create your application here
            register = FindViewById<Button>(Resource.Id.register);
            registerAdmin = FindViewById<Button>(Resource.Id.registerAdmin);


            register.Click += Register_Click;
            registerAdmin.Click += RegisterAdmin_Click;


        }

        private void RegisterAdmin_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = OpenFileOutput("isRegistered.txt", FileCreationMode.Private))
                {
                    try
                    {
                        stream.Write(Encoding.ASCII.GetBytes("Admin"), 0, "Admin".Length);
                        stream.Close();
                        Toast.MakeText(this, "registered", ToastLength.Long).Show();
                    }
                    catch
                    {
                        Console.WriteLine("Write Inner Try Error");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Write Outer Try Error");

            }
            Intent intent = new Intent(this, typeof(VolunteerMenu));
            StartActivity(intent);
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                using (Stream stream = OpenFileOutput("isRegistered.txt", FileCreationMode.Private))
                {
                    try
                    {
                        stream.Write(Encoding.ASCII.GetBytes("Registration Complete"), 0, "Registration Complete".Length);
                        stream.Close();
                        Toast.MakeText(this, "registered", ToastLength.Long).Show();
                    }
                    catch
                    {
                        Console.WriteLine("Write Inner Try Error");
                    }
                }
            }
            catch
            {
                Console.WriteLine("Write Outer Try Error");

            }
            Intent intent = new Intent(this, typeof(VolunteerMenu));
            StartActivity(intent);
        }
    }
}