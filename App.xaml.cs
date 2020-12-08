using System;
using Xamarin.Forms;
namespace Login
{
    public partial class App : Application
    {
        
        public App()
        {
            //Application.Current.Properties["IsLoggedIn"] = Boolean.TrueString;
            //Application.Current.Properties["email"] = "iyonpriyono";

            InitializeComponent();
            bool isLoggedIn = Current.Properties.ContainsKey("IsLoggedIn") ? Convert.ToBoolean(Current.Properties["IsLoggedIn"]) : false;
            

            if (!isLoggedIn)
            {
                //Load if Not Logged In
                MainPage = new Login.Pages.LoginPage();
            }
            else
            {
                //Load if Logged In
                MainPage = new Login.Pages.Baru();
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts  
        }
        protected override void OnSleep()
        {
            // Handle when your app sleeps  
        }
        protected override void OnResume()
        {
            // Handle when your app resumes  
        }
    }
}
