using System;
using System.Web.UI;
using BusinessLayer;
using ModelLayer;


namespace WebApplication1.Views
{
    public partial class VehicleType : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpId"] == null)
            {
                Response.Redirect("../login.aspx");
                return;
            }
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            GetVehicleTypes();
        }

        private void GetVehicleTypes()
        {
            try
            {
                var ml = new VehicleType_ML()
                {

                };
                gridVehicleTypes.DataSource = new VehicleType_BL().GetVehicleTypes(ml);
                gridVehicleTypes.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CloseModal()
        {
            txtName.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#VehicleTypeModal').modal('hide')});</script>", false);
        }

        protected void btnClose_ServerClick(object sender, EventArgs e)
        {
            CloseModal();
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new VehicleType_ML()
                {
                    VehicleType = txtName.Text
                };
                new VehicleType_BL().AddVehicletype(ml);
                GetVehicleTypes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnUpdate_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new VehicleType_ML(gridVehicleTypes.GetSelectedFieldValues("VehicleTypeID")[0].ToString(), txtName.Text);
                new VehicleType_BL().UpdateVehicletype(ml);
                GetVehicleTypes();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnAdd_ServerClick(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#VehicleTypeModal').modal('show')});</script>", false);
        }

        protected void btnDelete_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (gridVehicleTypes.Selection.Count > 0)
                {
                    var ml = new VehicleType_ML()
                    {
                        VehicleTypeID = (Int32)gridVehicleTypes.GetSelectedFieldValues("VehicleTypeID")[0]
                    };
                    new VehicleType_BL().DeleteVehicletype(ml);
                    GetVehicleTypes();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#SelectErrorModal').modal('show')});</script>", false);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnEdit_ServerClick(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnUpdate.Visible = true;

            try
            {
                if (gridVehicleTypes.Selection.Count > 0)
                {
                    txtName.Text = (string)gridVehicleTypes.GetSelectedFieldValues("VehicleTypeName")[0];
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#VehicleTypeModal').modal('show')});</script>", false);
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#SelectErrorModal').modal('show')});</script>", false);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}