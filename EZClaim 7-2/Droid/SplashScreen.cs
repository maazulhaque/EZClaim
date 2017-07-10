using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
//using UIKit;
using Android.Support.V7.App;

namespace EZClaim.Droid
{
    [Activity(Theme = "@style/MyTheme.Splash", MainLauncher = true, NoHistory = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class SplashScreen : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        // Launches the startup task
        protected override void OnResume()
        {
            base.OnResume();
            Intent main = new Intent(Application.Context, typeof(MainActivity));

            System.Threading.Thread.Sleep(1);

            StartActivity(main);
        }
    }
}