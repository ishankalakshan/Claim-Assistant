using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class changepassword : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["em_no"] == null)
        {
            Session["ret_url"] = "applyclaim.aspx";
            Response.Redirect("deafult.aspx");
        }
        sp_name.InnerHtml = Session["em_name"].ToString();

        if (Page.IsPostBack == true)
        {
            return;
        }

        if (Session["em_dept_no"].ToString() == "1")
        {
            sp_link.InnerHtml = "<a href='employee.aspx'>EMPLOYEE</a>&nbsp; |&nbsp; <a href='approveclaim.aspx'>APPROVE CLAIM</a>&nbsp; |&nbsp; <a href='viewstatus.aspx'>VIEW STATUS</a>&nbsp; |&nbsp; ";
        }
        else
        {
            sp_link.InnerHtml = "<a href='applyclaim.aspx'>APPLICATION</a>&nbsp; |&nbsp; <a href='viewstatus.aspx'>VIEW STATUS</a>&nbsp; |&nbsp; ";
           
        }

    }
    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("mypage.aspx");
    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid == true)
        {
            if (TxtOldPassword.Text == "")
            {
                MyClass.MyAlert(this, "Enter old password.", "123");
                return;
            }

            if (TxtNewPassword.Text == "")
            {
                MyClass.MyAlert(this, "Enter new password.", "123");
                return;
            }
            if (TxtNewPassword.Text != TxtConfirmPassword.Text)
            {
                MyClass.MyAlert(this, "New and confirm Password are not match.", "123");
                return;
            }

            //check for old password
            //check login
            string connectionInfo = ConfigurationManager.AppSettings["ConnectionInfo"];
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connectionInfo;

            DataTable table = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * FROM emp_master where em_no = " + Session["em_no"].ToString() + " and em_password='" + TxtOldPassword.Text + "'", cn);
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Fill(table);
            if (table.Rows.Count == 1)
            {
                DataRow r;
                r = table.Rows[0];
                r["em_password"] = TxtNewPassword.Text;
                da.Update(table);
                this.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script language=\"javaScript\">" + "alert('Password changed successfully!');" + "window.location.href='mypage.aspx';" + "<" + "/script>");

            }
            else
            {
                MyClass.MyAlert(this, "Login Failed, check your email id and password.", "123");
                return;
            }
        }
            
    }
}
