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
    public partial class frmAddNewVehicle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetVehicleTypes();
        }
        private void GetVehicleTypes()
        {
            var Vehicle = new VehicleType_ML();
            ddVehicleType.DataSource = new VehicleType_BL().GetVehicleTypes(Vehicle);
            ddVehicleType.DataBind();
        }
    }
}