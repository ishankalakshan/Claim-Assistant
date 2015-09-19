using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace DataLayer
{
    public class GetPolicyDetails_DL : DBConnection
    {
        public string GetPolicyDetails(GetPolicyDetails_ML ml)
        {

            var strFileName = Path.Combine(Environment.GetFolderPath(
             Environment.SpecialFolder.ApplicationData), "log.xml");

            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("sp_GetPolicyDetails", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@policy_id", ml.policyID);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);

                //ds.Tables.Add(dt);
                //ds.WriteXml(strFileName, XmlWriteMode.IgnoreSchema);
                string json = JsonConvert.SerializeObject(dt,Formatting.Indented);
                return json;
            }
            catch (SqlException ex)
            {
                return "fail";
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }
    }
}
