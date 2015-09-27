using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;
using BusinessLayer;
using System.Data;

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

        public bool Authenticate(string username, string password)
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
            return new GarageView_BL().GetGarageInfo(new GarageView_ML() { GarageLocation = location });
        }

        public bool InsertClaim(Claim_ML claim)
        {
            return false;
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
    }
}
