using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void BtnLogin_Click(object sender, EventArgs e)
    {
        //login and return page call
        if (TxtLogin.Text == "")
        {
            MyClass.MyAlert(this, "Enter employee no.", "123");
            return;
        }
        if (TxtPassword.Text == "")
        {
            MyClass.MyAlert(this, "Enter password.", "123");
            return;
        }
        string connectionInfo = ConfigurationManager.AppSettings["ConnectionInfo"];
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = connectionInfo;
        if (cn.State == ConnectionState.Closed)
        {
            cn.Open();
        }


        SqlDataAdapter da = new SqlDataAdapter("select em_no,em_name,em_dept_no,em_email,es_last_login2 from emp_master,emp_security where em_no=es_em_no and em_no=" + TxtLogin.Text + " and em_password='" + TxtPassword.Text + "'", cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        if (dt.Rows.Count == 1)
        {
            //Alert.Show("ok");

            SqlCommand com = new SqlCommand("select dept_name from department where dept_no =" + dt.Rows[0]["em_dept_no"].ToString(), cn);
            string dname;
            dname=com.ExecuteScalar().ToString();

            Session["em_no"] = dt.Rows[0]["em_no"].ToString();
            Session["em_name"] ="<b>"+ dt.Rows[0]["em_name"].ToString() + " [" + dname + "]</b>";
            Session["em_dept_no"] = dt.Rows[0]["em_dept_no"].ToString();
            Session["em_email"] = dt.Rows[0]["em_email"].ToString();
            Session["es_last_login2"] = dt.Rows[0]["es_last_login2"].ToString();

            com = new SqlCommand("update emp_security set es_last_login2=es_last_login1, es_last_login1=getdate() where es_em_no = " + dt.Rows[0]["em_no"].ToString(), cn);
            com.ExecuteNonQuery();
            if (Session["ret_url"] == null)
            {
                Response.Redirect("mypage.aspx");
            }
            else
            {
                Response.Redirect(Session["ret_url"].ToString());
            }
        }
        else
        {
            MyClass.MyAlert(this, "Can not login, Inavlid employee no/password.", "123");
            return;
        }
    }
}
