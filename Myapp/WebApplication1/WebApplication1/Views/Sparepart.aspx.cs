using ModelLayer;
using ModelLayer.Spareparts;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace WebApplication1.Views
{
    public partial class Spareparts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetSpareparts();
        }

        protected void btnClose_ServerClick(object sender, EventArgs e)
        {

        }

        protected void btnEdit_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (gridSpareparts.Selection.Count > 0)
                {
                    var id = (Int32)gridSpareparts.GetSelectedFieldValues("sparepartId")[0];
                    txtName.Text = (string)gridSpareparts.GetSelectedFieldValues("sparepartModel")[0];
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#SparepartModal').modal('show')});</script>", false);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#SelectErrorModal').modal('show')});</script>", false);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void GetSpareparts()
        {
            var SparepartList = new List<Sparepart_ML>();
            SparepartList.Add(new Sparepart_ML() { sparepartId = 4, sparepartModel = "C345", spareManufacturer = 4, sparepartCategory = 3, spareManufacYear = "2015", spareUnitCost = "244234.324" });

            gridSpareparts.DataSource = SparepartList;
            gridSpareparts.DataBind();

        }
        private void CloseModal()
        {
            txtName.Text = "";
            txtUnitCost.Value = "";
            txtYear.Value ="";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#SparepartModal').modal('hide')});</script>", false);
        }
    }
}