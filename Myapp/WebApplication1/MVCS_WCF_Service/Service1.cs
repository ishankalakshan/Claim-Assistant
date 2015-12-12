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
            var result = new Policy_BL().GetPolicy(new Policy_ML() { policyID = policy_ID });
            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }

        public string GetClaimHistory(int policy_ID)
        {
            var result = new Policy_BL().GetClaimHistory(new Policy_ML() { policyID = policy_ID });
            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }

        public string GetGarageInfo(string location)
        {
            var result = new Garage_BL().GetGarageData(new Garage_ML() { GarageLocation = location});
            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }

        public string GetTowTruckServiceInfo(string location)
        {
            var result = new TowTruckService_BL().GetTowTruckServices(new TowTruckService_ML() { location = location });
            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }

        public bool InsertClaim(string claim)
        {
            var call = new Claim_BL().createClaimObject(claim);

            return true;
        }

        public int AddClaimRequest(string claimRequest)
        {
            return new ClaimRequest_BL().AddClaimRequest(new ClaimRequest_BL().CreateClaimRequestObject(claimRequest));
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
            var result = new BusinessLayer.SparepartCategory_BL().GetSparepartCategories(
                new ModelLayer.Spareparts.SparepartCategory_ML() { spareCategoryName = "" });

            return JsonConvert.SerializeObject(result,Formatting.Indented);
        }

        public string GetSparepartManufacturers()
        {
            var result = new Manufacturer_BL().GetManufacturers(new Manufacturer_ML() { ManufacturerName = "" });
            return JsonConvert.SerializeObject(result,Formatting.Indented);
        }

        public string GetSpareparts(string manufacturer, string catergory)
        {
            var result = new BusinessLayer.Sparepart_BL().GetSpareparts(
                new ModelLayer.Spareparts.Sparepart_ML() { spareManufacturerName = manufacturer, sparepartCategoryName = catergory, sparepartModel = "", spareManufacYear = "" });

            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }
    }
}
