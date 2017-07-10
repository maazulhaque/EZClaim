using System;
using System.Collections.ObjectModel;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace EZClaim
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        private Home selectedHome;
        private Global _globalInstance;

        public HomePage()
        {
            InitializeComponent();
            _globalInstance = Global.GetInstance();
        }

        public HomePage(Home selectedHome)
        {
            InitializeComponent();
            _globalInstance = Global.GetInstance();

            this.selectedHome = selectedHome;
            HomeViewModel.GetInstance().populate(selectedHome);
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            HomeViewModel vm = HomeViewModel.GetInstance();
            ObservableCollection<Home> list = _globalInstance.Homes;

            if (vm.Address.Trim().Equals("") || vm.PostalCode.Trim().Equals(""))
            {
                await DisplayAlert("Fields Required", "Please fill in Address and Postal Code information", "OK");
                return;
            }

            Home home = new Home() { Address = vm.Address, City = vm.City, InsuranceCompany = vm.InsuranceCompany, PolicyNumber = vm.PolicyNumber, PostalCode = vm.PostalCode };

            //check if modified or newly added
            Home item = list.FirstOrDefault(i => i.Address.Equals(home.Address, StringComparison.CurrentCultureIgnoreCase) && i.PostalCode.Equals(home.PostalCode, StringComparison.CurrentCultureIgnoreCase));
            if (item != null)
            {
                _globalInstance.Homes.Remove(item);
            }

            _globalInstance.Homes.Add(home);

            await Navigation.PopModalAsync(true);

            //call rester here to save collection
        }

        async private void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }

    }
}

