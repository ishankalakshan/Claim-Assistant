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
        
        private bool state;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        private void UserAuthenticate()
        {
            var User = new UserLogin_ML();
            {
                User.username = txtUsername.Text;
                User.password = txtPassword.Text;
            };

            state = new UserLogin_BL().UserAuthentication(User);
            if (state)
            {
                Response.Redirect("Home.aspx");
            }
            else
            {
                Response.Redirect("Error.aspx");
            }
        }
        protected void btnLogin_Click(object sender, EventArgs e)
        {
            UserAuthenticate();  
        }
    }
}