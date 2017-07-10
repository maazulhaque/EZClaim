using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZClaim

{
    class Global
    {
        private static Global _this;
        private ObservableCollection<Auto> _autos { get; set; }
        private ObservableCollection<Home> _homes { get; set; }

        private Global()
        {
            // get default items for now
            GetDefaultItems();
        }

        public static Global GetInstance()
        {
            if (_this == null)
            {
                _this = new Global();
            }

            return _this;
        }

        public ObservableCollection<Auto> Autos
        {
            get { return _autos; }
            set
            {
                _autos = value;
            }
        }

        public ObservableCollection<Home> Homes
        {
            get { return _homes; }
            set
            {
                _homes = value;
            }
        }

        public void GetDefaultItems()
        {
            ObservableCollection<Auto> autos = new ObservableCollection<Auto>();
            autos = new ObservableCollection<Auto>
            {
                new Auto() { Vehicle="TAYOTA", Make="LEXUS", Model="IS 250", LicensePlate="BXDN 944", Year=2011 },
                new Auto() { Vehicle="TAYOTA", Make="CAMERY", Model="LE", LicensePlate="ABCD 123", Year=2012 },
            };
            Autos = autos;

            ObservableCollection<Home> homes = new ObservableCollection<Home>();
            homes = new ObservableCollection<Home>
            {
                new Home() { Address="98 Fairhill Avenue", City="Brampton", InsuranceCompany="State Farm Insurance", PolicyNumber="123456789", PostalCode="L7A 2E9"},
                new Home() { Address="86 Porter Court", City="Guelph", InsuranceCompany="State Farm Insurance", PolicyNumber="123456789", PostalCode="N1L 1L8"},
            };
            Homes = homes;
        }
    }
}
