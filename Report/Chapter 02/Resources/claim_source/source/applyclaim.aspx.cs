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

public partial class applyclaim : System.Web.UI.Page
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


        DdlType.Items.Add("---Select---");
        DdlType.Items.Add("Medicines");
        DdlType.Items.Add("Laboratory Tests");
        DdlType.Items.Add("Surgery");
        DdlType.Items.Add("Others");



    }
    protected void BtnSubmit_Click(object sender, EventArgs e)
    {
        //validation
        if (Page.IsValid == true)
        {

            string connectionInfo = ConfigurationManager.AppSettings["ConnectionInfo"];
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = connectionInfo;
            if (cn.State == ConnectionState.Closed)
            {
                cn.Open();
            }

            SqlCommand com = new SqlCommand("select max(ec_id) from emp_claims", cn);
            int lastid;
            lastid=int.Parse(com.ExecuteScalar().ToString());

            SqlDataAdapter da = new SqlDataAdapter("select * from emp_claims where 1=2", cn);
            DataTable dt = new DataTable();
            SqlCommandBuilder cb = new SqlCommandBuilder(da);
            da.Fill(dt);

            DataRow r;
            r=dt.NewRow();
            r["ec_id"]=lastid+1;
            r["ec_type"]=DdlType.Text;
            r["ec_amount"]=double.Parse(TxtAmount.Text);
            r["ec_desc"]=TxtDescription.Text;
            r["ec_apply_date"]=DateTime.Now.ToString();
            r["ec_em_no"]=Session["em_no"].ToString();
   
            dt.Rows.Add(r);

            da.Update(dt);


            this.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script language=\"javaScript\">" + "alert('New application saved successfully!');" + "window.location.href='mypage.aspx';" + "<" + "/script>");


        }

    }
    protected void BtnBack_Click(object sender, EventArgs e)
    {
        Response.Redirect("mypage.aspx");
    }
}
