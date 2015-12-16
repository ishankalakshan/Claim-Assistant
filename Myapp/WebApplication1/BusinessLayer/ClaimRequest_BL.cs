using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;
using System.Data;
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
                    return 2;
                }
            }
            else
            {
                return 1;
            }
            
            
        }

        public bool CheckPolicyNumberValidity(ClaimRequest_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@policy_id",ml.PolicyId}
                };

                DBAccessController db = new DBAccessController();
                var dt = db.RetriveRecordsWithPara(StoredProcedures.sp_GetPolicyDetails, DataDic);
                if (dt.Rows.Count > 0)
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
                var claimRequestObj = new ClaimRequest_ML(jArray["PolicyId"].ToString(), jArray["Latitude"].ToString(), jArray["Longitude"].ToString(), jArray["Status"].ToString(), DateTime.Now);               
                return claimRequestObj;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public DataTable GetClaimRequests(string status)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Status",status}
                };

                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetClaimRequests, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool UpdateClaimRequest(ClaimRequest_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@claimRequestId",ml.Id},
                    {"@EmpId",ml.RespondEmployeeId},
                    {"@status",ml.Status},
                    {"@respondtime",ml.RespondTime}
                };
                new DBAccessController().InsertRecord(StoredProcedures.sp_UpdateClaimRequest, DataDic);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
