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
    public partial class frmNew3wheelStep2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        private void GetVehicleTypes()
        {
            var Vehicle = new VehicleType_ML();
            //cmbVehicleType.DataSource = new VehicleType_BL().GetVehicleTypes(Vehicle);
            //cmbVehicleType.DataBind();
        }

        protected void cmbVehicleType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmNew3wheelStep3.aspx");
        }
    }
}