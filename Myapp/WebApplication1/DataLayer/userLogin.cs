using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Web;
using ModelLayer;

namespace DataLayer
{
    public class userLogin : DBConnection 
    {
        /// <summary>
        /// Method responsible to to the user authentication
        /// </summary>
        /// <param name="tblUser"></param>
        /// <returns></returns>
        public bool authenticate(UserLogin_ML ml)
        {

            con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                //cmd = new SqlCommand("select * from userAccounts where username =@username and password=@password", con);
                cmd = new SqlCommand("sp_authenticate", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@username", ml.username);
                cmd.Parameters.AddWithValue("@password", ml.password);

                adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                cmd.ExecuteNonQuery();

                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Session["Username"] = ml.username;    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }

        public bool authenticate_app(UserLogin_ML ml)
        {

            con = new SqlConnection(connectionString);

            try
            {
                con.Open();
                //cmd = new SqlCommand("select * from userAccounts where username =@username and password=@password", con);
                cmd = new SqlCommand("sp_authenticate", con) { CommandType = CommandType.StoredProcedure };
                cmd.Parameters.AddWithValue("@username", ml.username);
                cmd.Parameters.AddWithValue("@password", ml.password);

                adp = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                cmd.ExecuteNonQuery();

                adp.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    //Session["Username"] = ml.username;    
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
