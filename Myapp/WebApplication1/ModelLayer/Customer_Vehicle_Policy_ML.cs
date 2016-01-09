using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Customer_Vehicle_Policy_ML
    {
        public int CustomerVehiclePolicyId { get; set; }
        public int CustomerVehicleId { get; set; }
        public string Type { get; set; }
        public DateTime CommenceOn { get; set; }
        public DateTime ExpireOn { get; set; }
        public string NaturalDisaster { get; set; }
        public string Vandalism { get; set; }
        public string Terrorism { get; set; }
        public string StrikeRiot { get; set; }
        public string AirBag { get; set; }
        public decimal PassengerComp { get; set; }
        public decimal Towing { get; set; }
        public decimal DriverComp { get; set; }
        public string status { get; set; }
        public int empId { get; set; }
    }
}
