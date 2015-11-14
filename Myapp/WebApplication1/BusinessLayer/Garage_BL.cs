using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelLayer;
using DataLayer;

namespace BusinessLayer
{
    public class Garage_BL
    {
        public DataTable GetGarageData(Garage_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object> 
                { 
                    {"@location", ml.GarageLocation}
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetGarageDetails, DataDic);
            }
            catch
            {
                throw;
            }
        }

        public bool DeleteGarage(Garage_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@GarageID", ml.GarageID}
                };
                return new DBAccessController().DeleteRecord(StoredProcedures.sp_RemoveGarage, DataDic);
            }
            catch (System.Exception)
            {

                throw;
            }
        }

        public bool AddGarage(Garage_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@GarageName", ml.GarageName},
                    {"@GarageLocation",ml.GarageLocation},
                    {"@GarageTP",ml.GarageTP},
                    {"@Email",ml.Email}
                };

                return new DBAccessController().InsertRecord(StoredProcedures.sp_AddGarage, DataDic);
            }
            catch (System.Exception)
            {
                throw;
            }
        }
        
        public bool UpdateGarage(Garage_ML ml)
        {
            try
            {
                 var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.GarageID},
                    {"@GarageName", ml.GarageName},
                    {"@GarageLocation",ml.GarageLocation},
                    {"@GarageTP",ml.GarageTP},
                    {"@Email",ml.Email}
                };

                return new DBAccessController().UpdateRecord(StoredProcedures.sp_UpdateGarage, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
