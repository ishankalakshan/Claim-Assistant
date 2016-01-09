using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelLayer
{
    public class Customer_Vehicle_ML
    {
        public int CustomerVehicleId { get; set; }
        public int CustomerId { get; set; }
        public int VehicleId { get; set; }
        public string RegNo { get; set; }
        public string Color { get; set; }
        public string EngineNo { get; set; }
        public string ChassissNo { get; set; }
        public string Usage { get; set; }
        public string ExtraFitting { get; set; }
        public string Damages { get; set; }
        public string AbsoluteOwner { get; set; }
        public string FinancialRights { get; set; }
    }
}
