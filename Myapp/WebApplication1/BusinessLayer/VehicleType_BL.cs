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
    public class VehicleType_BL
    {
        public DataTable GetVehicleTypes(VehicleType_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>();
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetVehicleTypes, DataDic);
            }
            catch
            {
                throw;
            }
        }

        public bool AddVehicletype(VehicleType_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@VehicleTypeName", ml.VehicleType},

                };

                return new DBAccessController().InsertRecord(StoredProcedures.sp_AddVehicleType, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool DeleteVehicletype(VehicleType_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.VehicleTypeID}
                };
                return new DBAccessController().DeleteRecord(StoredProcedures.sp_RemoveVehicleType, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool UpdateVehicletype(VehicleType_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.VehicleTypeID},
                    {"@VehicleTypeName", ml.VehicleType}
                };

                return new DBAccessController().InsertRecord(StoredProcedures.sp_UpdateVehicleType, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
