using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelLayer;
using BusinessLayer;

namespace WebApplication1
{
    public partial class login : System.Web.UI.Page
    {

        private bool _state;

        protected void Page_Load(object sender, EventArgs e)
        {
            erroralert.Visible = false;
        }
        private void UserAuthenticate()
        {
            var User = new UserLogin_ML();
            {
                User.username = txtUsername.Value;
                User.password = txtPassword.Value;
            };

            _state = new UserLogin_BL().UserAuthentication(User);
            if (_state)
            {
                switch (Session["type"].ToString())
                {
                    case "staff":
                        erroralert.Visible = false;
                        Response.Redirect("Views/Home.aspx");
                        break;
                    case "admin":
                        erroralert.Visible = false;
                        Response.Redirect("Views/Home.aspx");
                        break;
                    case "agent":
                        errorMsg.InnerText = "You do not have permission to access the system. Please contact system administrator";
                        erroralert.Visible = true;
                        break;
                    default:
                        errorMsg.InnerText = "Error occured.Please contact system administrator";
                        erroralert.Visible = true;
                        break;
                }

            }
            else
            {
                errorMsg.InnerText = "Username or password you have entered is incorrect";
                erroralert.Visible = true;
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserAuthenticate();
        }
    }
}