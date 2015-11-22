using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using DataLayer;
using System.Data;


namespace BusinessLayer
{
    public class Policy_BL
    {
        public DataTable GetPolicy(Policy_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@policy_id",ml.policyID}
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetPolicyDetails, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable GetClaimHistory(Policy_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@policy_id",ml.policyID}
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetClaimHistory, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
