using System;
using System.Collections.Generic;
using System.Web.UI;
using BusinessLayer;
using ModelLayer;

namespace WebApplication1.Views
{
    public partial class Vehicle : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpId"] == null)
            {
                Response.Redirect("../login.aspx");
                return;
            }
            if (!IsPostBack)
            {
                btnUpdate.Visible = false;
                btnSave.Visible = true;
                GetVehicles();
                GetTypes();
                GetManufacturers();
            }
        }

        protected void btnAdd_ServerClick(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#VehicleModal').modal('show')});</script>", false);
        }

        protected void btnRemove_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (gridVehicle.Selection.Count > 0)
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#DeleteModal').modal('show')});</script>", false);
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
            btnUpdate.Visible = true;
            btnSave.Visible = false;

            try
            {
                if (gridVehicle.Selection.Count>0)
                {
                    ddlType.SelectedValue = gridVehicle.GetSelectedFieldValues("VehicleTypeID")[0].ToString();
                    ddlmanufacturer.SelectedValue = gridVehicle.GetSelectedFieldValues("ManufactureId")[0].ToString();
                    txtModel.Value = gridVehicle.GetSelectedFieldValues("Model")[0].ToString();
                    txtYear.Value = gridVehicle.GetSelectedFieldValues("MakeYear")[0].ToString();
                    ddlFuel.SelectedValue = gridVehicle.GetSelectedFieldValues("FuelType")[0].ToString();
                    txtEngineCapacity.Value = gridVehicle.GetSelectedFieldValues("EngineCpacity")[0].ToString(); ;
                    txtSeatCapacity.Value = gridVehicle.GetSelectedFieldValues("seatingCapacity")[0].ToString();
                    txtCarryCapacity.Value = gridVehicle.GetSelectedFieldValues("CarryingCapacity")[0].ToString();
                    txtPresentVal.Value = gridVehicle.GetSelectedFieldValues("PresentValue")[0].ToString();
                    txtDutyFreeVal.Value = gridVehicle.GetSelectedFieldValues("DutyFreeValue")[0].ToString();
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#VehicleModal').modal('show')});</script>", false);
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

        protected void btnClose_ServerClick(object sender, EventArgs e)
        {

        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new Vehicle_ML(
                    "0",
                    ddlType.SelectedValue.ToString(),
                    ddlmanufacturer.SelectedValue.ToString(),
                    txtModel.Value,
                    txtYear.Value,
                    ddlFuel.SelectedValue.ToString(),
                    txtEngineCapacity.Value,
                    txtSeatCapacity.Value,
                    txtCarryCapacity.Value,
                    txtPresentVal.Value,
                    txtDutyFreeVal.Value
                    );

                new Vehicle_BL().AddVehicle(ml);
                GetVehicles();
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
                var f = ddlType.SelectedValue;
                var hj = ddlType.SelectedItem;
                var ml = new Vehicle_ML(
                    gridVehicle.GetSelectedFieldValues("VehicleID")[0].ToString(),
                    ddlType.SelectedValue.ToString(),
                    ddlmanufacturer.SelectedValue.ToString(),
                    txtModel.Value,
                    txtYear.Value,
                    ddlFuel.SelectedValue.ToString(),
                    txtEngineCapacity.Value,
                    txtSeatCapacity.Value,
                    txtCarryCapacity.Value,
                    txtPresentVal.Value,
                    txtDutyFreeVal.Value
                    );

                new Vehicle_BL().UpdateVehicle(ml);
                GetVehicles();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void btnDelete_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new Vehicle_ML() { VehicleID=Convert.ToInt32(gridVehicle.GetSelectedFieldValues("VehicleID")[0])};
                new Vehicle_BL().DeleteVehicle(ml);
                GetVehicles();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GetVehicles()
        {
            try
            {
                var ml = new Vehicle_ML()
                {
                    VehicleTypeName = string.IsNullOrEmpty(txtTypeSearch.Text) ? "" : txtTypeSearch.Text,
                    ManufactureName = string.IsNullOrEmpty(txtManufactureSearch.Text) ? "" : txtManufactureSearch.Text,
                    Model = string.IsNullOrEmpty(txtModelSearch.Text) ? "" : txtModelSearch.Text,
                    MakeYear = string.IsNullOrEmpty(txtYearSearch.Text) ? "" : txtYearSearch.Text
                };

                gridVehicle.DataSource = new Vehicle_BL().GetVehicles(ml);
                gridVehicle.DataBind();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GetTypes()
        {
            try
            {
                var ml = new VehicleType_ML();
                ddlType.DataTextField = "VehicleTypeName";
                ddlType.DataValueField = "VehicleTypeID";
                ddlType.DataSource = new VehicleType_BL().GetVehicleTypes(ml);
                ddlType.DataBind();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GetManufacturers()
        {
            try
            {
                var ml = new Manufacturer_ML() { ManufacturerName="" };
                ddlmanufacturer.DataTextField = "ManufactureName";
                ddlmanufacturer.DataValueField = "ManufactureId";
                ddlmanufacturer.DataSource = new Manufacturer_BL().GetManufacturers(ml);
                ddlmanufacturer.DataBind();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}