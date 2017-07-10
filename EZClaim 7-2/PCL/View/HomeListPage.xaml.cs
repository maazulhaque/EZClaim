using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EZClaim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeListPage : ContentPage
    {
        private Global _globalInstance;

        public HomeListPage()
        {
            InitializeComponent();

            _globalInstance = Global.GetInstance();
            listView.ItemsSource = _globalInstance.Homes;
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Page page = new NavigationPage(new HomePage())
            {
                BarBackgroundColor = Color.FromHex("#367aa3"),
                BarTextColor = Color.White
            };
            await Navigation.PushModalAsync(page);
        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            listView.SelectedItem = null;
        }

        private void delete_Clicked(object sender, EventArgs e)
        {
            var home = (sender as MenuItem).CommandParameter as Home;
            _globalInstance.Homes.Remove(home);
        }

        async private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedHome = e.Item as Home;
            Page page = new NavigationPage(new HomePage(selectedHome))
            {
                BarBackgroundColor = Color.FromHex("#367aa3"),
                BarTextColor = Color.White
            };

            await Navigation.PushModalAsync(page);
        }
    }
}
