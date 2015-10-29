using System.Data;
using System.Data.SqlClient;

namespace DataLayer.Spareparts
{
    public class SparepartManufacturer_DL
    {
        public DataTable GetSparepartManufacturers()
        {
            try
            {
                return new DBAccessController().RetriveAllRecords(StoredProcedures.sp_GetSparepartManufacturers);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
