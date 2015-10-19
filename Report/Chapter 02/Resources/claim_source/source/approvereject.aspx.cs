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

public partial class approvereject : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["em_no"] == null)
        {
            Session["ret_url"] = "viewstatus.aspx";
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


        //display data
        string connectionInfo = ConfigurationManager.AppSettings["ConnectionInfo"];
        SqlConnection cn = new SqlConnection();
        cn.ConnectionString = connectionInfo;
        if (cn.State == ConnectionState.Closed)
        {
            cn.Open();
        }

        string s1 = " and ec_approve_date is null";
        string s2 = " ";

        string s3;
        s3 = "SELECT emp_claims.ec_id  , emp_master.em_name, emp_master.em_no , emp_claims.ec_em_no , emp_claims.ec_type , " +
            " emp_claims.ec_amount , emp_claims.ec_desc, emp_claims.ec_apply_date ,emp_claims.ec_approve_status  " +
            " FROM emp_claims INNER JOIN emp_master ON emp_claims.ec_em_no = emp_master.em_no where ec_id = " + Request.QueryString["id"].ToString();

        SqlDataAdapter da = new SqlDataAdapter(s3, cn);
        DataTable dt = new DataTable();

        da.Fill(dt);

        DataRow r;
        r = dt.Rows[0];
        TxtEmployee.Text = r["em_name"].ToString() + " [" + r["em_no"].ToString() + "]";
        TxtApplyDate.Text = r["ec_apply_date"].ToString();
        TxtClaimType.Text = r["ec_type"].ToString();
        TxtAmount.Text = r["ec_amount"].ToString();
        TxtDescription.Text = r["ec_desc"].ToString();


    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        if (Page.IsValid == true)
        {
            string connectionInfo = ConfigurationManager.AppSettings["ConnectionInfo"];
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connectionInfo;
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }
            string s1;
            if (RdApprove.Checked == true)
            {
                s1 = "Approved";
            }
            else
            {
                s1 = "Rejected";
            }

            SqlCommand com = new SqlCommand("update emp_claims set ec_approve_status='" + s1 + "',ec_approve_date=getdate(),ec_approve_remarks='" + TxtRemarks.Text + "' where ec_id=" + Request.QueryString["id"].ToString(), cn);
            com.ExecuteNonQuery();

            this.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script language=\"javaScript\">" + "alert('Changes saved successfully!');" + "window.location.href='approveclaim.aspx';" + "<" + "/script>");



        }
    }
    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("approveclaim.aspx");
    }
}
