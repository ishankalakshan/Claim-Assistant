using System.Data;
using System.Data.SqlClient;

namespace DataLayer.Spareparts
{
    public class Sparepart_DL
    {
        public DataTable GetSpareparts()
        {
            try
            {
                return new DBAccessController().RetriveAllRecords(StoredProcedures.sp_GetSpareparts);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
