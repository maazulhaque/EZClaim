using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EZClaim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private ILoginManager _loginManager;

        public LoginPage(ILoginManager ilm)
        {
            InitializeComponent();
            _loginManager = ilm;
        }

        private void login_Clicked(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(emailAddress.Text) || String.IsNullOrEmpty(password.Text))
            {
                DisplayAlert("Validation Error", "Email Address and Password are required", "Re-try");
            }
            else
            {
                // REMEMBER LOGIN STATUS!
                App.Current.Properties["IsLoggedIn"] = true;
                _loginManager.ShowMainPage();
            }
        }

        private void createAccount_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<ContentPage>(this, "Create");
        }

        //new Label { Text = "Login", FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label)) }, 


    }
}
