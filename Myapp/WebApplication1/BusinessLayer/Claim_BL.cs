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
        public bool createClaimObject(string jstring)
        {
            try
            {
                var sparelist = new List<SparepartPayment_ML>();
                var obj = JObject.Parse(jstring);
                var jArray = JObject.Parse(jstring);
                var sparelistArry = JArray.Parse(jArray["spareParts"].ToString());

                foreach (var item in sparelistArry)
                {
                    sparelist.Add(new SparepartPayment_ML()
                    {
                        sparePartId = (int)item["SparepartId"],
                        sparePartCost = (double)item["SparepartCost"],
                        sparePartQty = (double)item["SparepartQty"]
                    });
                }

                var claimObj = new Claim_ML(Convert.ToInt32(jArray["policyId"].ToString()),
                   jArray["location"].ToString(),
                   jArray["reason"].ToString(),
                   jArray["knockedOn"].ToString(),
                   jArray["_3rdVehicleNo"].ToString(),
                   jArray["_3rdOwnerName"].ToString(),
                   jArray["_3rdAddress"].ToString(),
                   jArray["_3rdContactNo"].ToString(),
                   Convert.ToDateTime(jArray["_3rdRenewalDate"].ToString()),
                   jArray["_3rdSpecialNotes"].ToString(),
                   jArray["_3rdVictimName"].ToString(),
                   jArray["_3rdVictimAddress"].ToString(),
                   jArray["_3rdDamageNature"].ToString(),
                   jArray["_3rdClaimant"].ToString(),
                   Convert.ToDouble(jArray["_3rdAmountClaimed"].ToString()),
                   jArray["isDriverOwner"].ToString(),
                   jArray["driverName"].ToString(),
                   jArray["driverLicense"].ToString(),
                   jArray["licenseCat"].ToString(),
                   Convert.ToDateTime(jArray["licenseExpreDate"].ToString()),
                   jArray["driverNIC"].ToString(),
                   Convert.ToDateTime(jArray["purchaseDate".ToString()]),
                   jArray["VehicleUsedFor"].ToString(),
                   jArray["rentCompanyName"].ToString(),
                   0,
                   sparelist,
                   jArray["garageCosts"].ToString(),
                   jArray["otherCosts"].ToString(),
                   jArray["empid"].ToString()
                   );

                insertClaim(claimObj);

                return true;
            }
            catch (Exception)
            {
                
                throw;
            }
            
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
