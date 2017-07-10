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
    public partial class CreateAccountPage : ContentPage
    {
        private ILoginManager _loginManager;

        public CreateAccountPage(ILoginManager ilm)
        {
            InitializeComponent();
            _loginManager = ilm;
        }

        private void createAccount_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Account created", "Add processing login here", "OK");
            _loginManager.ShowMainPage();
        }

        private void cancel_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Send<ContentPage>(this, "Login");
        }
    }
}
