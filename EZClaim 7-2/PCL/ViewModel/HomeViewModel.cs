using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//using System.Windows.Input;

namespace EZClaim
{
    public class HomeViewModel : ViewModelBase
    {
        private string _insuranceCompany = "";
        private string _policyNumber = "";
        private string _address = "";
        private string _city = "";
        private string _postalCode = "";

        private static HomeViewModel _this;

        //public ICommand SaveAutoInfoCommand { get; private set; }

        public HomeViewModel()
        {
            _this = this;
        }

        public static HomeViewModel GetInstance()
        {
            return _this;
        }

        public void populate(Home home)
        {
            InsuranceCompany = home.InsuranceCompany;
            PolicyNumber = home.PolicyNumber;
            Address = home.Address;
            City = home.City;
            PostalCode = home.PostalCode;
        }

        public String InsuranceCompany
        {
            get { return _insuranceCompany; }
            set
            {
                _insuranceCompany = value;
                OnPropertyChanged("InsuranceCompany");
            }
        }

        public String PolicyNumber
        {
            get { return _policyNumber; }
            set
            {
                _policyNumber = value;
                OnPropertyChanged("PolicyNumber");
            }
        }

        public String Address
        {
            get { return _address; }
            set
            {
                _address = value;
                OnPropertyChanged("Address");
            }
        }

        public String City
        {
            get { return _city; }
            set
            {
                _city = value;
                OnPropertyChanged("City");
            }
        }

        public String PostalCode
        {
            get { return _postalCode; }
            set
            {
                _postalCode = value;
                OnPropertyChanged("PostalCode");
            }
        }
    }
}
