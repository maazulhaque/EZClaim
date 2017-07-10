using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
//using System.Windows.Input;
using System.Collections.ObjectModel;

namespace EZClaim
{
    public class AutoViewModel : ViewModelBase
    {
        private string _vehicle = "";
        private string _model = "";
        private string _make = "";
        private int _year;
        private string _licensePlate = "";
        private string _vin = "";
        private string _policyNumber = "";
        private string _insuranceCompany = "";

        private static AutoViewModel _this;

        public AutoViewModel() {
            _this = this;
            //populate autos collection through rester service call
        }

        public static AutoViewModel GetInstance()
        {
            return _this;
        }

        public void populate(Auto auto)
        {
            Vehicle = auto.Vehicle;
            Model = auto.Model;
            Make = auto.Make;
            Year = auto.Year;
            LicensePlate = auto.LicensePlate;
            VIN = auto.VIN;
    }

        public String Vehicle
        {
            get { return _vehicle; }
            set
            {
                _vehicle = value;
                OnPropertyChanged("Vehicle");
            }
        }

        public String Model
        {
            get { return _model; }
            set
            {
                _model = value;
                OnPropertyChanged("Model");
            }
        }

        public String Make
        {
            get { return _make; }
            set
            {
                _make = value;
                OnPropertyChanged("Make");
            }
        }

        public int Year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged("Year");
            }
        }

        public string VIN
        {
            get { return _vin; }
            set
            {
                _vin = value;
                OnPropertyChanged("VIN");
            }
        }

        public String LicensePlate
        {
            get { return _licensePlate; }
            set
            {
                _licensePlate = value;
                OnPropertyChanged("LicensePlate");
            }
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
    }
}
