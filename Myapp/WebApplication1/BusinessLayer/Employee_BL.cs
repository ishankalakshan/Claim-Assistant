using DataLayer;
using ModelLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class Employee_BL
    {
        public bool AddEmployee(Employee_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@EmpName", ml.EmpName},
                    {"@EmpPhone",ml.EmpPhone},
                    {"@EmpEmail",ml.EmpEmail},
                    {"@EmpBranch",ml.EmpBranch}
                };

                return new DBAccessController().InsertRecord(StoredProcedures.sp_AddEmployee, DataDic);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }
    }
}
