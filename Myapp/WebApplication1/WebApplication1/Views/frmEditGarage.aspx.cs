using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelLayer;
using BusinessLayer;
using System.Data;

namespace WebApplication1.Views
{
    public partial class frmEditGarage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String GarageID = Request.QueryString["GarageID"];
            var GarageEditID = new GarageView_ML();
            {
                GarageEditID.GarageID = Convert.ToInt32(GarageID);

            };

           DataTable dt= new GarageView_BL().GetGarageByID(GarageEditID);
           txtGarageName.Text = dt.Rows[0]["GarageName"].ToString();
           txtGarageLocation.Text = dt.Rows[0]["GarageLocation"].ToString();
           txtGarageTP.Text = dt.Rows[0]["GarageTP"].ToString();
           
        }

        protected void txtGarageName_Validation(object sender, DevExpress.Web.ValidationEventArgs e)
        {
            if ((e.Value as string).Length < 2)
                e.IsValid = false;
        }
    }
}