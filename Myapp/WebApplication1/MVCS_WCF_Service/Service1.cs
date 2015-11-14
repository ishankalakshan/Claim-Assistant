using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;
using BusinessLayer;
using System.Data;
using BusinessLayer.Spareparts;
using Newtonsoft.Json;

namespace MVCS_WCF_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class Service1 : IService1
    {
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public string Authenticate(string username, string password)
        {
            return new UserLogin_BL().UserAuthentication_App(new UserLogin_ML() { username = username, password = password });
        }

        public string GetPolicyInfo(int policy_ID)
        {
            //return new GetPolicyDetails_BL().GetPolicyDetails(new GetPolicyDetails_ML() { policyID=policy_ID });
            return new GetPolicyDetails_BL().GetPolicyDetails(new GetPolicyDetails_ML() { policyID = 4 });
        }

        public string GetGarageInfo(string location)
        {
            return JsonConvert.SerializeObject(new Garage_BL().GetGarageData(new Garage_ML() { GarageLocation = location }), Formatting.Indented);
        }

        public string GetTowTruckServiceInfo(string location)
        {
            return new TowTruckService_BL().GetTowTruckServiceInfo(new TowTruckService_ML() { location = location });
        }

        public bool InsertClaim(string claim)
        {
            var call =new Claim_BL().createClaimObject(claim);

            return true;
        }
        
        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

       public string GetSparepartCategories()
       {
            var result = new BusinessLayer.Spareparts.SparepartCategory_BL().GetSparepartCategories();
            var resultJString = JsonConvert.SerializeObject(result);
            return resultJString;
       }

        public string GetSparepartManufacturers()
        {
            var result = new SparepartManufacturer_BL().GetSparepartManufacturers();
            var resultJString = JsonConvert.SerializeObject(result);
            return resultJString;
        }

        public string GetSpareparts()
        {
            var result = new Sparepart_BL().GetSpareparts();
            var resultJString = JsonConvert.SerializeObject(result);
            return resultJString;
        }
    }
}
