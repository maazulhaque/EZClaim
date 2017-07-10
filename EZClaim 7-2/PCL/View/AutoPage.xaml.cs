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
    public partial class AutoPage : ContentPage
    {
        private Auto selectedAuto;
        private Global _globalInstance;

        public AutoPage()
        {
            InitializeComponent();
            _globalInstance = Global.GetInstance();
        }

        public AutoPage(Auto selectedAuto)
        {
            InitializeComponent();
            _globalInstance = Global.GetInstance();

            this.selectedAuto = selectedAuto;
            AutoViewModel.GetInstance().populate(selectedAuto);
        }

        async private void Button_Clicked(object sender, EventArgs e)
        {
            AutoViewModel vm = AutoViewModel.GetInstance();
            ObservableCollection<Auto> list = _globalInstance.Autos;

            if(vm.Vehicle.Trim().Equals("") || vm.LicensePlate.Trim().Equals(""))
            {
                await DisplayAlert("Fields Required", "Please fill in Vehicle or License Plate information", "OK");
                return;
            }

            Auto auto = new Auto() { Vehicle = vm.Vehicle, Make = vm.Make, Model = vm.Make, LicensePlate = vm.LicensePlate, Year = vm.Year, InsuranceCompany = vm.InsuranceCompany, PolicyNumber = vm.PolicyNumber ,VIN = vm.VIN };

            //check if modified or newly added
            Auto item = list.FirstOrDefault(i => i.LicensePlate.Equals(auto.LicensePlate, StringComparison.CurrentCultureIgnoreCase));
            if(item != null)
            {
                _globalInstance.Autos.Remove(item);
            }

            _globalInstance.Autos.Add(auto);

            await Navigation.PopModalAsync(true);

            //call rester here to save collection
        }

        async private void Cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync(true);
        }
    }
}
