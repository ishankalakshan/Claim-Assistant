using Newtonsoft.Json;
using System.Data;
using System.Data.SqlClient;
using ModelLayer;

namespace DataLayer
{
   public class TowTruckService_DL : DBConnection
    {
       public string GetTowTruckInfo(TowTruckService_ML ml) 
        {
            DataTable dt = new DataTable();

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("sp_GetTowTruckServices", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Location", ml.location);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                string json = JsonConvert.SerializeObject(dt, Formatting.Indented);
                return json;
            }
            catch (SqlException ex)
            {
                return "Fail";
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
 
        }
    }
}
