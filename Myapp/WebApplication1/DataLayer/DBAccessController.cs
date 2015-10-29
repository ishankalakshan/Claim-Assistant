
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class DBAccessController : DBConnection
    {
        public DataTable RetriveAllRecords(string storedProcedureName)
        {
            var dt = new DataTable();
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand(storedProcedureName, con) { CommandType = CommandType.StoredProcedure };
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                return dt;
            }
            catch (System.Exception)
            {      
                throw;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
        
    }
}
