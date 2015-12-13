using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelLayer;
using BusinessLayer;

namespace WebApplication1.Views
{
    public partial class ClaimRequests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetClaimRequests();
        }

        private void GetClaimRequests()
        {
            gridClaimRequests.DataSource = new ClaimRequest_BL().GetClaimRequests(txtStatusSearch.Text);
            gridClaimRequests.DataBind();
        } 


    }
}