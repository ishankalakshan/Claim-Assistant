using ModelLayer;
using DataLayer;
using System.Collections.Generic;
using System;
using Newtonsoft.Json.Linq;

namespace BusinessLayer
{
    public class ClaimRequest_BL
    {
        public int AddClaimRequest(ClaimRequest_ML ml)
        {
            if (CheckPolicyNumberValidity(ml))
            {
                try
                {
                    var DataDic = new Dictionary<string, object>
                {
                    {"@PolicyId", ml.PolicyId},
                    {"@Latitude",ml.Latitude},
                    {"@Longitude",ml.Longitude},
                    {"@status",ml.Status},
                    {"@submittime",ml.SubmitTime}
                };
                    new DBAccessController().InsertRecord(StoredProcedures.sp_AddClaimRequest, DataDic);
                    return 0;
                }
                catch (System.Exception)
                {

                    throw;
                }
            }
            else
            {
                return 1;
            }
            
            
        }

        private bool CheckPolicyNumberValidity(ClaimRequest_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@policy_id",ml.PolicyId}
                };
                var dt = new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetPolicyDetails, DataDic);
                if (dt.Rows.Count>0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public ClaimRequest_ML CreateClaimRequestObject(string claimRequest)
        {
            try
            {
                //var obj = JObject.Parse(claimRequest);
                var jArray = JObject.Parse(claimRequest);
                var claimRequestObj = new ClaimRequest_ML(jArray["policyId"].ToString(), jArray["latitude"].ToString(), jArray["longitude"].ToString(), jArray["status"].ToString(), DateTime.Now);               
                return claimRequestObj;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
