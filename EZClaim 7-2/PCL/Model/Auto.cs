using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EZClaim
{
    public class Auto
    {
        public string Vehicle { get; set; }

        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public string LicensePlate { get; set; }

        public string VIN { get; set; }

        public string PolicyNumber { get; set; }

        public string InsuranceCompany { get; set; }

        public string VehicleMake => string.Format("{0} {1}", Vehicle, Make);

        public string ModelLicense => string.Format("{0}, {1}", Model, LicensePlate);

        public bool Equals(Auto auto)
        {
            //if (auto != null &&
            //    auto.Vehicle.Equals(Vehicle) &&
            //    auto.MakeModel.Equals(MakeModel) &&
            //    auto.Year == Year &&
            //    auto.LicensePlate.Equals(LicensePlate) &&
            //    auto.VIN.Equals(VIN)
            //    )
            //{
            //    return true;
            //}
            return false;
        }
    }
}
