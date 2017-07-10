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
    public partial class CallAgentPage : ContentPage
    {
        public CallAgentPage()
        {
            InitializeComponent();
        }

        private void NotifyAuto_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Auto Notify", "OK");
        }

        private void NotifyHome_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Home Notify", "OK");
        }
    }
}
