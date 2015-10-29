using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;

namespace BusinessLayer
{
    public class Claim_BL
    {
        public Claim_ML createClaimObject(string jstring)
        {
            var obj = JObject.Parse(jstring);
            var jArray = JArray.Parse(jstring);

            return null;
        }

        public bool insertClaim(Claim_ML ml)
        {
            try
            {
                Claim_DL claim = new Claim_DL();
               return claim.insertClaim(ml,claim.InsertClaimPayment(ml),claim.insertDriverDetails(ml),claim.insertThirdPartyDetails(ml));

            }
            catch
            {
                throw;
            }
        }

    }
}
