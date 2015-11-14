using DataLayer;
using ModelLayer;
using System.Collections.Generic;
using System.Data;

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

        public DataTable GetEmployees(Employee_ML ml) {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@EmpName",ml.EmpName},
                    {"@EmpBranch",ml.EmpBranch}
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetEmployeeDetails, DataDic);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public bool DeleteEmployee(Employee_ML ml) 
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@EmpId", ml.EmpId}
                };
                return new DBAccessController().DeleteRecord(StoredProcedures.sp_RemoveEmployee, DataDic);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public bool UpdateEmployee(Employee_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@EmpId", ml.EmpId},
                    {"@EmpName", ml.EmpName},
                    {"@EmpPhone",ml.EmpPhone},
                    {"@EmpEmail",ml.EmpEmail},
                    {"@EmpBranch",ml.EmpBranch}
                };

                return new DBAccessController().UpdateRecord(StoredProcedures.sp_UpdateEmployee, DataDic);
            }
            catch (System.Exception)
            {
                return false;
                throw;
            }
        }
    }
}
