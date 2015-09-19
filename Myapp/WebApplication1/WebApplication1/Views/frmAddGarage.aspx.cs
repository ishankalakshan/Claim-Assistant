using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelLayer;
using BusinessLayer;
using System.Drawing;

namespace WebApplication1.Views
{
    public partial class frmAddGarage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            var AddGarage = new GarageView_ML();
            {
                AddGarage.garageName = string.IsNullOrEmpty(txtGarageName.Text) ? null : txtGarageName.Text;
                AddGarage.GarageLocation = string.IsNullOrEmpty(txtGarageLocation.Text) ? null : txtGarageLocation.Text;
                AddGarage.GarageTP = string.IsNullOrEmpty(txtGarageTP.Text) ? null : txtGarageTP.Text;
                
            };
            new GarageView_BL().AddGarage(AddGarage);
            Response.Redirect("Garages.aspx");
        }

        protected void txtGarageName_Validation(object sender, DevExpress.Web.ValidationEventArgs e)
        {
            if ((e.Value as string).Length < 2)
                e.IsValid = false;
        }
    }
}