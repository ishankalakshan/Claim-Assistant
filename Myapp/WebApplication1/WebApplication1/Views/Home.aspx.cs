using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpId"] == null)
            {
                Response.Redirect("../login.aspx");
                return;
            }
            if (Session["type"]!=null && Session["type"].ToString()=="admin")
            {
                tileUserAccount.Visible = true;
            }
            else
            {
                tileUserAccount.Visible = false;
            }
        }

        protected void btnLogout_ServerClick(object sender, EventArgs e)
        {
            Session.Clear();
            Session.Abandon();
            Response.Redirect("../login.aspx");
        }
    }
}