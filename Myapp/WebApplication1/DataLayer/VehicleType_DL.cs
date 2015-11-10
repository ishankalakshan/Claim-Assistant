using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;
using System.Data;
using System.Data.SqlClient;

namespace DataLayer
{
    public class VehicleType_DL : DBConnection
    {
        public DataTable GetVehicleTypes(VehicleType_ML ml)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("[sp_GetVehicleTypes]", con) { CommandType = CommandType.StoredProcedure };
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

        

       /* public DataTable GetManufacturers(Manufacturer_ML ml)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("[sp_Getmanufacturers]", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@VehicleType", ml.VehicleType);
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
        }*/

        public DataTable GetVehicleList(Manufacturer_ML ml)
        {
            DataTable dt = new DataTable();

            try
            {
                con = new SqlConnection(connectionString);
                con.Open();

                cmd = new SqlCommand("[sp_GetVehicles]", con) { CommandType = CommandType.StoredProcedure };
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
    }
}
