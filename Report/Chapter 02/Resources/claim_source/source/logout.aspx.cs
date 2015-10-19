using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;

public partial class logout : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Session["em_no"] = "";
        Session["em_name"] = "";
        Session["em_dept_no"] = "";
        Session["em_email"] = "";
        Session["es_last_login2"] = "";

        Response.Redirect("default.aspx");
    }
}
