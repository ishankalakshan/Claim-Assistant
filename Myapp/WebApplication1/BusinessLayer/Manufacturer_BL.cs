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
    public class Manufacturer_BL
    {
        public DataTable GetManufacturers(Manufacturer_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@ManufactureName",ml.ManufacturerName}
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetManufacturer, DataDic);

            }
            catch
            {
                throw;
            }
        }

        public bool AddManufacturer(Manufacturer_ML ml)
        {
            try
            {
                try
                {
                    var DataDic = new Dictionary<string, object>
                {
                    {"@ManufactureName", ml.ManufacturerName}
                };

                    return new DBAccessController().InsertRecord(StoredProcedures.sp_AddManufacturer, DataDic);
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool DeleteManufacturer(Manufacturer_ML ml)
        {
            try
            {
                try
                {
                    var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.ManufacturerId}
                };
                    return new DBAccessController().DeleteRecord(StoredProcedures.sp_RemoveManufacturer, DataDic);
                }
                catch (System.Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool UpdateManufacturer(Manufacturer_ML ml)
        {
            try
            {
                try
            {
                 var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.ManufacturerId},
                    {"@ManufactureName", ml.ManufacturerName}
                };

                return new DBAccessController().UpdateRecord(StoredProcedures.sp_UpdateManufacturer, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
