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

public partial class newemployee : System.Web.UI.Page
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


        //fill dept,desi
        SqlDataAdapter da = new SqlDataAdapter("select dept_name from department" , cn);
        DataTable dt = new DataTable();
        da.Fill(dt);
        DdlDept.Items.Clear();
        DdlDept.Items.Add ("--Select--");
        int i;
        for(i=0;i<=dt.Rows.Count -1;i++)
        {
            DdlDept.Items.Add (dt.Rows[i]["dept_name"].ToString());
        }

        da = new SqlDataAdapter("select des_name from designation", cn);
        dt = new DataTable();
        da.Fill(dt);
        DdlDesignation.Items.Clear();
        DdlDesignation.Items.Add("--Select--");

        for(i=0;i<=dt.Rows.Count -1;i++)
        {
            DdlDesignation.Items.Add(dt.Rows[i]["des_name"].ToString());
        }


        string s3;

        s3=" SELECT emp_master.em_no, emp_master.em_name, department.dept_name, designation.des_name, " +
            " emp_master.em_email, emp_master.em_dob, emp_master.em_address, emp_master.em_home_no, " +
            " emp_master.em_office_no, emp_master.em_mobile FROM emp_master INNER JOIN " +
            " department ON emp_master.em_dept_no = department.dept_no INNER JOIN " +
            " designation ON emp_master.em_des_no = designation.des_no where em_no=" + Request.QueryString["id"].ToString();

        da = new SqlDataAdapter(s3, cn);
        dt = new DataTable();

        da.Fill(dt);

        if (dt.Rows.Count > 0)
        {
            DataRow r;
            r = dt.Rows[0];

            TxtEmpNo.Text = r["em_no"].ToString();
            TxtName.Text = r["em_name"].ToString();
            DdlDept.Text = r["dept_name"].ToString();
            DdlDesignation.Text = r["des_name"].ToString();
            TxtEmailID.Text = r["em_email"].ToString();
            TxtDob.Text = r["em_dob"].ToString();
            TxtAddress.Text = r["em_address"].ToString();
            TxtTeleResi.Text = r["em_home_no"].ToString();
            TxtTeleOff.Text = r["em_office_no"].ToString();
            TxtMobile.Text = r["em_mobile"].ToString();

        }
        else
        {
            TxtEmpNo.Text = "";
            TxtName.Text = "";
            DdlDept.Text = "";
            DdlDesignation.Text = "";
            TxtEmailID.Text = "";
            TxtDob.Text = "";
            TxtAddress.Text = "";
            TxtTeleResi.Text ="";
            TxtTeleOff.Text = "";
            TxtMobile.Text = "";
        }

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

            int lastid,deptno,desino,lastesid;
            SqlCommand com;
            //get last empno
            com = new SqlCommand("select max(em_no) from emp_master ", cn);
            lastid = int.Parse(com.ExecuteScalar().ToString()) +1;

            //get last empsecno
            com = new SqlCommand("select max(es_id) from emp_security", cn);
            lastesid = int.Parse(com.ExecuteScalar().ToString())+1;

            //get dept/desg no
            com=new SqlCommand("select dept_no from department where  dept_name ='" + DdlDept.Text +"'",cn);
            deptno=int.Parse(com.ExecuteScalar().ToString());

            com=new SqlCommand("select des_no from designation where  des_name ='" + DdlDesignation.Text +"'",cn);
            desino=int.Parse(com.ExecuteScalar().ToString());

            //edit or delete
            SqlDataAdapter da = new SqlDataAdapter("select * from emp_master where em_no =" + Request.QueryString["id"].ToString(), cn);
            SqlCommandBuilder cb=new SqlCommandBuilder(da);
            DataTable dt=new DataTable();
            
            da.Fill(dt);
            DataRow r;
            if (dt.Rows.Count>0)
            {
                
                r=dt.Rows[0];
                r["em_name"]=TxtName.Text;
                r["em_dept_no"] = deptno;
                r["em_des_no"] = desino;
                r["em_email"]=TxtEmailID.Text;
                r["em_dob"]=TxtDob.Text;
                r["em_address"]=TxtAddress.Text;
                r["em_home_no"]=TxtTeleResi.Text ;
                r["em_office_no"]=TxtTeleOff.Text;
                r["em_mobile"]=TxtMobile.Text ;

                da.Update(dt);

                

            }
            else
            {

                
                r=dt.NewRow();
                r["em_no"]=lastid;
                r["em_name"]=TxtName.Text;
                r["em_dept_no"] = deptno;
                r["em_des_no"] = desino;
                r["em_email"]=TxtEmailID.Text;
                r["em_dob"]=TxtDob.Text;
                r["em_address"]=TxtAddress.Text;
                r["em_home_no"]=TxtTeleResi.Text ;
                r["em_office_no"]=TxtTeleOff.Text;
                r["em_mobile"]=TxtMobile.Text ;
                r["em_password"]="123456";
                r["em_create_date"]=DateTime.Now.ToString();

                dt.Rows.Add(r);
                da.Update(dt);

                com = new SqlCommand("insert into emp_security values(" + lastesid.ToString() + "," + lastid.ToString() + ",null,null,null)", cn);
                int j;
                j = com.ExecuteNonQuery();

            }


        }

        this.ClientScript.RegisterStartupScript(this.GetType(), "Alert", "<script language=\"javaScript\">" + "alert('New changed saved successfully!');" + "window.location.href='employee.aspx';" + "<" + "/script>");
    }
    protected void BtnBack_Click(object sender, EventArgs e)
    {
        
        Response.Redirect("employee.aspx");
    }
}
