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

namespace FinalProjectV0._1
{
    [Activity(Label = "RegisterPagesActivity")]
    public class RegisterPagesActivity : Activity
    {
        #region register1_parameters;
        EditText nameInput, phoneInput, mailInput, adressInput;
        RadioGroup genderRadioGroup;
        RadioButton gender_male, gender_female, gender_other;
        Button register1Submit;
        #endregion
        #region register2_parameters
        Button btnOrganizationSelectorDialog;
        #endregion
        #region register3_parameters;
        Button register, registerAdmin;
        #endregion
        protected override void OnCreate(Bundle savedInstanceState)
        {
            
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource

            #region register1
            SetContentView(Resource.Layout.Register1);
            // Create your application here
            nameInput = FindViewById<EditText>(Resource.Id.NameInput);
            phoneInput = FindViewById<EditText>(Resource.Id.PhoneInput);
            mailInput = FindViewById<EditText>(Resource.Id.MailInput);
            adressInput = FindViewById<EditText>(Resource.Id.AdressInput);
            register1Submit = FindViewById<Button>(Resource.Id.register1Submit);
            //TODO: recieve and process EVERY input

            register1Submit.Click += Register1Submit_Click;
            #endregion
            

        }

        private void Register1Submit_Click(object sender, EventArgs e)
        {
            #region register2
            SetContentView(Resource.Layout.Register2);
            btnOrganizationSelectorDialog = FindViewById<Button>(Resource.Id.btnOrganizationSelectorDialog);

            btnOrganizationSelectorDialog.Click += BtnOrganizationSelectorDialog_Click;

            //TODO: add support for multiple organizations
            #endregion

        }

        private void BtnOrganizationSelectorDialog_Click(object sender, EventArgs e)
        {
            #region register3
            SetContentView(Resource.Layout.Register3);
            register = FindViewById<Button>(Resource.Id.register);
            registerAdmin = FindViewById<Button>(Resource.Id.registerAdmin);



            register.Click += Register_Click;
            registerAdmin.Click += RegisterAdmin_Click;
            #endregion
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
    }
}