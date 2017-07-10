using Xamarin.Forms;
using System;

namespace EZClaim
{
    public class App : Application, ILoginManager
    {
        //static ILoginManager loginManager;
        public static App Current;

        public App()
        {
            Current = this;

            var isLoggedIn = Properties.ContainsKey("IsLoggedIn") ? (bool)Properties["IsLoggedIn"] : false;

            isLoggedIn = true;

            // we remember if they're logged in, and only display the login page if they're not
            if (isLoggedIn)
                MainPage = new EZClaim.MainPage(this);
            else
                MainPage = new LoginModalPage(this);
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

        public void ShowMainPage()
        {
            MainPage = new MainPage(this);
        }

        public void Logout()
        {
            Properties["IsLoggedIn"] = false; // only gets set to 'true' on the LoginPage
            MainPage = new LoginModalPage(this);
        }
    }
}

