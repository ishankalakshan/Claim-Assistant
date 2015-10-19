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

public partial class approveclaim : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["em_no"] == null)
        {
            Session["ret_url"] = "approveclaim.aspx";
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

        displaygrid();
    }
    private void displaygrid()
    {
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
        s3 = "SELECT emp_claims.ec_id AS [Ref. No.], emp_master.em_name as [Emp. Name], emp_claims.ec_em_no AS [Emp. No.], emp_claims.ec_type AS [Type], " +
            " emp_claims.ec_amount AS [Amount], emp_claims.ec_desc as [Decsription], emp_claims.ec_apply_date AS [Apply Date],emp_claims.ec_approve_status AS [Approve/Reject] " +
            " FROM emp_claims INNER JOIN emp_master ON emp_claims.ec_em_no = emp_master.em_no where 1 = 1 " + s1 + s2 + " order by ec_id desc ";

        SqlDataAdapter da = new SqlDataAdapter(s3, cn);
        DataTable dt = new DataTable();

        da.Fill(dt);
        sp_count.InnerHtml = "<strong>" + dt.Rows.Count.ToString() + " Application pending for approve/reject.</strong> ";

        ViewState["dt"] = dt;
        GridView1.DataSource = ViewState["dt"];
        GridView1.DataBind();

    }

    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        displaygrid();
    }
    protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowIndex >= 0)
        {
            string s1, s2;
            s2 = "";
            s1 = "<a href='approvereject.aspx?id=" +  e.Row.Cells[0].Text + "'>Edit</a>";

            e.Row.Cells[7].Text = s1;
        }
    }
    protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        GridView1.PageIndex = e.NewPageIndex;
        GridView1.DataSource = ViewState["dt"];
        GridView1.DataBind();
    }
}
