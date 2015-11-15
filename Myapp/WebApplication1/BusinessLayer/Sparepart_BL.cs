using System;
using System.Collections.Generic;
using ModelLayer;
using DataLayer;
using System.Data;
using ModelLayer.Spareparts;

namespace BusinessLayer
{
    public class Sparepart_BL
    {
        public DataTable GetSpareparts(Sparepart_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object> 
                { 
                    {"@sparepartName", ml.sparepartModel},
                    {"@sparepartCategory", ml.sparepartCategoryName},
                    {"@sparepartManufacturer", ml.spareManufacturerName},
                    {"@spareparManufacYear", ml.spareManufacYear}
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetSparepart, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool AddSparepart(Sparepart_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@sparepartName", ml.sparepartModel},
                    {"@sparepartCategory", ml.sparepartCategory},
                    {"@sparepartManufacturer", ml.spareManufacturer},
                    {"@spareparManufacYear", ml.spareManufacYear},
                    {"@sparepartUnitCost", ml.spareUnitCost}
                };

            return new DBAccessController().InsertRecord(StoredProcedures.sp_AddSparepart, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        public bool DeleteSparepart(Sparepart_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.sparepartId},

                };

                return new DBAccessController().UpdateRecord(StoredProcedures.sp_RemoveSparepart, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            } 
        }

        public bool UpdateSparepart(Sparepart_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.sparepartId},
                    {"@sparepartName", ml.sparepartModel},
                    {"@sparepartCategory", ml.sparepartCategory},
                    {"@sparepartManufacturer", ml.spareManufacturer},
                    {"@spareparManufacYear", ml.spareManufacYear},
                    {"@sparepartUnitCost", ml.spareUnitCost}
                };

                return new DBAccessController().InsertRecord(StoredProcedures.sp_UpdateSparepart, DataDic);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
