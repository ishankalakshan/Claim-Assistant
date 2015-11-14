using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ModelLayer;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace DataLayer
{
    public class Garage_DL : DBConnection
    {
        public DataTable GetGarageData(Garage_ML ml)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("sp_GetGarageDetails", con) { CommandType = CommandType.StoredProcedure }; 
                cmd.Parameters.AddWithValue("@Location", ml.GarageLocation);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                return dt;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }

        public Boolean RemoveGarage(Garage_ML ml)
        {
            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("sp_RemoveGarage", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@GarageID", ml.GarageID);
                cmd.ExecuteNonQuery();               
                return true;
            }
            catch (SqlException ex)
            {
                return false;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
        }        
        public DataTable GetByGarageID(Garage_ML ml)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("sp_GetGarageByID", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@GarageID", ml.GarageID);
                adp = new SqlDataAdapter(cmd);
                adp.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                return dt;
            }
            finally
            {
                con.Close();
                con.Dispose();
            }

            return dt;
        }
        public string GetGarageInfo(Garage_ML ml) 
        {
            DataTable dt = new DataTable();

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("sp_GetGarageDetails", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@Location", ml.GarageLocation);
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
