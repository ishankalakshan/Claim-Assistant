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

        public DataTable GetAllClaims(Policy_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetAllPolicy, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public DataTable GetAllModels()
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetAllModels, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int InsertCustomer(Customer_ML ml) 
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Salutation", ml.Salutation},
                    {"@Initials",ml.Initials},
                    {"@Firstname",ml.Firstname},
                    {"@Lastname",ml.Lastname},
                    {"@AddressNo", ml.AddressNo},
                    {"@Street",ml.Street},
                    {"@City",ml.City},
                    {"@NIC",ml.Nic},
                    {"@Home", ml.Home},
                    {"@Office",ml.Office},
                    {"@Mobile",ml.Mobile},
                    {"@Email",ml.Email},
                    {"@Bank", ml.Bank},
                    {"@Branch",ml.Branch},
                    {"@Account",ml.AccountNo}
                };

                var returnparam = "@CustomerId";

                return new DBAccessController().InsertRecordGetId(StoredProcedures.sp_AddCustomer, DataDic, returnparam);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public int InsertCustomerVehicle(Customer_Vehicle_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@VehicleId", ml.VehicleId},
                    {"@CustomerId",ml.CustomerId},
                    {"@RegistrationNo",ml.RegNo},
                    {"@Color",ml.Color},
                    {"@EngineNo", ml.EngineNo},
                    {"@ChassisNo",ml.ChassissNo},
                    {"@CurrentDamages",ml.Damages},
                    {"@AbsoluteOwner",ml.AbsoluteOwner},
                    {"@FinancialRights", ml.FinancialRights},
                    {"@ExtraFittins",ml.ExtraFitting},
                    {"@Usage",ml.Usage}
                };

                return new DBAccessController().InsertRecordGetId(StoredProcedures.sp_AddVehicleCustomer, DataDic, "@CustomerVehicleId");
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool InsertCustomerVehiclepolicy(Customer_Vehicle_Policy_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@type", ml.Type},
                    {"@Vehicle_ID",ml.CustomerVehicleId},
                    {"@commenceOn",ml.CommenceOn},
                    {"@ExpireOn",ml.ExpireOn},
                    {"@natural_disaster", ml.NaturalDisaster},
                    {"@vandalism",ml.Vandalism},
                    {"@tercover",ml.Terrorism},
                    {"@strikes",ml.StrikeRiot},
                    {"@airbag", ml.AirBag},
                    {"@driver_compensation",ml.DriverComp},
                    {"@passenger_compensation",ml.PassengerComp},
                    {"@towing_charges",ml.Towing},
                    {"@status", ml.status},
                    {"@empId",ml.empId},
                };

                return new DBAccessController().InsertRecord(StoredProcedures.sp_AddVehicleCustomerPolicy, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        
    }
}
