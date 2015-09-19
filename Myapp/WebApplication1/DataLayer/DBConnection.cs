using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace DataLayer
{
    public class DBConnection : System.Web.UI.Page 
    {
        protected string connectionString;
        protected SqlConnection con;
        protected SqlCommand cmd;
        protected SqlDataAdapter adp;

        public DBConnection() {

            connectionString = ConfigurationManager.ConnectionStrings["DBConnection"].ConnectionString;
        }

    }


}
