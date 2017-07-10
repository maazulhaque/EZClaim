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
    public partial class AutoListPage : ContentPage
    {
        private Global _globalInstance;

        public AutoListPage()
        {
            InitializeComponent();

            _globalInstance = Global.GetInstance();
            listView.ItemsSource = _globalInstance.Autos;
        }

        async private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Page page = new NavigationPage(new AutoPage())
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
            var auto = (sender as MenuItem).CommandParameter as Auto;
            _globalInstance.Autos.Remove(auto);
        }

        async private void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedAuto = e.Item as Auto;
            Page page = new NavigationPage(new AutoPage(selectedAuto))
            {
                BarBackgroundColor = Color.FromHex("#367aa3"),
                BarTextColor = Color.White
            };

            await Navigation.PushModalAsync(page);
        }
    }
}
