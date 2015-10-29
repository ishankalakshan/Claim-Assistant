using System.Data;
using System.Data.SqlClient;


namespace DataLayer
{
    public class SparePartCategory_DL 
    {
        public DataTable GetSparepartCategories()
        {         
            try
            {
                return new DBAccessController().RetriveAllRecords(StoredProcedures.sp_GetSparepartCategories);
            }
            catch (SqlException ex)
            {
                throw ex;
            }        
        }
    }
}
