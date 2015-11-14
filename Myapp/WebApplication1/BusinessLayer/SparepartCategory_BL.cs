using ModelLayer;
using ModelLayer.Spareparts;
using System.Collections.Generic;
using DataLayer;
using System.Data;

namespace BusinessLayer
{
    public class SparepartCategory_BL
    {
        public bool AddSparepartCategory(SparepartCategory_ML ml) 
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@spareCategoryName", ml.spareCategoryName}
                };

              return  new DBAccessController().InsertRecord(StoredProcedures.sp_AddCategory, DataDic);
                
            }
            catch (System.Exception)
            {
                return false;
                throw;           
            }
        }

        public DataTable GetSparepartCategories(SparepartCategory_ML ml) 
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Name", ml.spareCategoryName}
                };
                return new DBAccessController().RetriveRecordsWithPara(StoredProcedures.sp_GetCategoryDetails, DataDic);
            }
            catch (System.Exception)
            {               
                throw;
            }    
        }

        public bool DeleteSparepartCategory(SparepartCategory_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Id", ml.spareCategoryId}
                };
                return new DBAccessController().DeleteRecord(StoredProcedures.sp_RemoveCategory, DataDic);
            }
            catch (System.Exception)
            {
                
                throw;
            }
        }

        public bool UpdateSparepartCategory(SparepartCategory_ML ml)
        {
            try
            {
                var DataDic = new Dictionary<string, object>
                {
                    {"@Id",ml.spareCategoryId},
                    {"@spareCategoryName", ml.spareCategoryName}
                };

                return new DBAccessController().UpdateRecord(StoredProcedures.sp_UpdateCategory, DataDic);

            }
            catch (System.Exception)
            {
                return false;
                throw;
            }
        }
    }
}
