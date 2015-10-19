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

public partial class mypage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["em_no"] == null)
        {
            Session["ret_url"] = "mypage.aspx";
            Response.Redirect("deafult.aspx");
        }
        sp_name.InnerHtml = Session["em_name"].ToString();

        string connectionInfo = ConfigurationManager.AppSettings["ConnectionInfo"];
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = connectionInfo;
        if (cn.State == ConnectionState.Closed)
        {
            cn.Open();
        }


        SqlCommand com = new SqlCommand();
        if (Session["em_dept_no"].ToString() == "1")
        {
            com.CommandText = "select count(*) from emp_claims where ec_approve_date is null";
        }
        else
        {
            com.CommandText = "select count(*) from emp_claims where ec_approve_date is null and ec_em_no = " + Session["em_no"].ToString();
        }
        com.CommandType = CommandType.Text;
        com.Connection = cn;
        int c;
        c = int.Parse(com.ExecuteScalar().ToString());


        if (Session["em_dept_no"].ToString() =="1" )
        {
            
            sp_link.InnerHtml = "<a href='employee.aspx'>EMPLOYEE</a>&nbsp; |&nbsp; <a href='approveclaim.aspx'>APPROVE CLAIM</a>&nbsp; |&nbsp; <a href='viewstatus.aspx'>VIEW STATUS</a>&nbsp; |&nbsp; ";
            sp_message.InnerHtml = "You have " + c.ToString() + " pending applications to approve";
        }
        else
        {

            sp_link.InnerHtml = "<a href='applyclaim.aspx'>APPLICATION</a>&nbsp; |&nbsp; <a href='viewstatus.aspx'>VIEW STATUS</a>&nbsp; |&nbsp; ";
            
            sp_message.InnerHtml = "Your " + c.ToString() + " applications is pending for approve";
        }
    }
}
