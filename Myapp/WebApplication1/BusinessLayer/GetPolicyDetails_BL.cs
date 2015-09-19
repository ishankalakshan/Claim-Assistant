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
    public class GetPolicyDetails_BL
    {
        public string GetPolicyDetails(GetPolicyDetails_ML ml)
        {
            try
            {
                return new GetPolicyDetails_DL().GetPolicyDetails(ml);

            }
            catch
            {
                throw;
            }
        }
    }
}
