using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ModelLayer;
using BusinessLayer;
using System.IO;

namespace Rest_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class RestService : IRestService
    {
        public string GetData()
        {
            return "This works";
        }

        public string PostMessage(string userName)
        {
            return string.Format("Welcome {0} to tungnt.net from PostMessage() WCF REST Service", userName);
        }

        public int AddClaimRequest(Stream claimRequest)
        {
            string claimRequestString = "";
            using (var reader = new StreamReader(claimRequest))
            {
                claimRequestString = reader.ReadToEnd();
            }
            return new ClaimRequest_BL().AddClaimRequest(new ClaimRequest_BL().CreateClaimRequestObject(claimRequestString)); 
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
