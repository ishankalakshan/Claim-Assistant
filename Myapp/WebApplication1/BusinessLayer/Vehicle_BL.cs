using DataLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Data;

namespace BusinessLayer
{
    public class Vehicle_BL
    {
        public DataTable GetVehicles(Vehicle_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object> 
                { 
                    {"@VehicleTypeName", ml.VehicleTypeName},
                    {"@ManufactureName", ml.ManufactureName},
                    {"@Model", ml.Model},
                    {"@MakeYear", ml.MakeYear}
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetVehicle, DataDic);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool AddVehicle(Vehicle_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@VehicleTypeID", ml.VehicleTypeID},
                    {"@ManufactureId",ml.ManufactureId},
                    {"@Model",ml.Model},
                    {"@MakeYear",ml.MakeYear},
                    {"@FuelType", ml.FuelType},
                    {"@EngineCpacity",ml.EngineCpacity},
                    {"@seatingCapacity",ml.seatingCapacity},
                    {"@CarryingCapacity",ml.CarryingCapacity},
                    {"@PresentValue", ml.PresentValue},
                    {"@DutyFreeValue",ml.DutyFreeValue}
                };

                return new DBAccessController().InsertRecord(StoredProcedures.sp_AddVehicle, DataDic);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteVehicle(Vehicle_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.VehicleID}
                };

                return new DBAccessController().DeleteRecord(StoredProcedures.sp_RemoveVehicle, DataDic);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateVehicle(Vehicle_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.VehicleID},
                    {"@VehicleTypeID", ml.VehicleTypeID},
                    {"@ManufactureId",ml.ManufactureId},
                    {"@Model",ml.Model},
                    {"@MakeYear",ml.MakeYear},
                    {"@FuelType", ml.FuelType},
                    {"@EngineCpacity",ml.EngineCpacity},
                    {"@seatingCapacity",ml.seatingCapacity},
                    {"@CarryingCapacity",ml.CarryingCapacity},
                    {"@PresentValue", ml.PresentValue},
                    {"@DutyFreeValue",ml.DutyFreeValue}
                };

                return new DBAccessController().UpdateRecord(StoredProcedures.sp_UpdateVehicle, DataDic);
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
