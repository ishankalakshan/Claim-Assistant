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
    public partial class frmNew3wheelStepV : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetVehicleList();
        }
        private void GetVehicleList()
        {

            //var vehicleTYpe = new Manufacturer_ML();
           // gridvehicles.DataSource = new VehicleManufac_BL().GetManufacturers(vehicleTYpe);
            //gridvehicles.DataBind();
        }

        protected void btnNext_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmNew3wheelStep2.aspx");
        }
    }
}