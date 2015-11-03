using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using ModelLayer;
using BusinessLayer;

namespace WebApplication1.Views
{
    public partial class Garages : System.Web.UI.Page
    {
        public GarageView_ML GarageEditID;

        protected void Page_Load(object sender, EventArgs e)
        {
           if (!IsPostBack)
            {
                GetGarageData();
                gridGarages.SettingsPopup.EditForm.Modal = true;
            }
        }
        private void GetGarageData()
         {
             var GarageSearchText = new GarageView_ML();
             {
                 GarageSearchText.GarageLocation = string.IsNullOrEmpty(txtLocationSearch.Text) ? "" : txtLocationSearch.Text;           
                 //GarageLocation = string.IsNullOrEmpty(txtLocationSearch.Text) ? null : txtLocationSearch.Text;
             };

             gridGarages.DataSource = new GarageView_BL().GetGarageData(GarageSearchText);
             gridGarages.DataBind();

         }

        protected void txtLocationSearch_TextChanged(object sender, EventArgs e)
        {
            GetGarageData();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Response.Redirect("frmAddGarage.aspx");
           //txtLocationSearch.Text= new GetPolicyDetails_BL().GetPolicyDetails(new GetPolicyDetails_ML() { policyID = 4 });
        }

        protected void btnRemove_Click(object sender, EventArgs e)
        {
            var GarageRemoveID = new GarageView_ML();
            {

             GarageRemoveID.GarageID = Convert.ToInt32(gridGarages.GetSelectedFieldValues("GarageID")[0].ToString());
            };
            new GarageView_BL().RemoveGarage(GarageRemoveID);
                    GetGarageData();
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            String GarageID = gridGarages.GetSelectedFieldValues("GarageID")[0].ToString();            
            Response.Redirect("frmEditGarage.aspx?GarageID=" + GarageID);
        }

    }
}