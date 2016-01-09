using BusinessLayer;
using ModelLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1.Views
{
    public partial class Policy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GetAllPolicyDetails();
                BindManufacturers();
                BindTypes();
                BindModels();
                GetVehicles();
            }

        }

        private void GetAllPolicyDetails()
        {
            var ml = new Policy_ML()
            {
                //EmpName = string.IsNullOrEmpty(txtNameSearch.Text) ? "" : txtNameSearch.Text,
                //EmpBranch = string.IsNullOrEmpty(txtBranchSearch.Text) ? "" : txtBranchSearch.Text
            };
            gridPolicy.DataSource = new Policy_BL().GetAllClaims(ml);
            gridPolicy.DataBind();
        }

        private void BindManufacturers()
        {
            try
            {
                var ml = new Manufacturer_ML() { ManufacturerName = "" };
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

        private void BindTypes()
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

        private void BindModels()
        {
            try
            {
                var ml = new VehicleType_ML();
                ddlModel.DataTextField = "Model";
                ddlModel.DataValueField = "Model";
                ddlModel.DataSource = new Policy_BL().GetAllModels();
                ddlModel.DataBind();
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
                    VehicleTypeName = string.IsNullOrEmpty(ddlType.SelectedItem.Text) ? "" : ddlType.SelectedItem.Text,
                    ManufactureName = string.IsNullOrEmpty(ddlmanufacturer.SelectedItem.Text) ? "" : ddlmanufacturer.SelectedItem.Text,
                    Model = string.IsNullOrEmpty(ddlModel.SelectedItem.Text) ? "" : ddlModel.SelectedItem.Text,
                    MakeYear = ""
                };

                gridVehicles.DataSource = new Vehicle_BL().GetVehicles(ml);
                gridVehicles.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVehicles();
        }

        protected void ddlmanufacturer_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVehicles();
        }

        protected void ddlModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetVehicles();
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var customerML = new Customer_ML() 
                { 
                    Salutation = txtSalutation.Value,
                    Initials = txtInitials.Value,
                    Firstname = txtFirstname.Value,
                    Lastname=txtLastname.Value,
                    AddressNo = txtAccountNo.Value,
                    Street=txtStreet.Value,
                    City=txtCity.Value,
                    Nic=txtNic.Value,
                    Email=txtEmail.Value,
                    Mobile=txtMobile.Value,
                    Home=txtHome.Value,
                    Office=txtOffice.Value,
                    Bank = txtBank.Value,
                    Branch = txtBranch.Value,
                    AccountNo = txtAccountNo.Value
                };

                var customerId = new Policy_BL().InsertCustomer(customerML);

                var vehicleCustomerML = new Customer_Vehicle_ML()
                {
                    CustomerId = customerId,
                    RegNo=txtRegNo.Value,
                    VehicleId = Convert.ToInt32(txtVehicleId.Text),
                    Color=txtColor.Value,
                    EngineNo=txtEngineNo.Value,
                    ChassissNo=txtChassissNo.Value,
                    Usage = txtUsage.Value,
                    ExtraFitting=txtExtra.Value,
                    Damages = txtDamages.Value,
                    AbsoluteOwner = txtAbsolute.Value,
                    FinancialRights = txtFinan.Value
                };

                var customerVehicleId = new Policy_BL().InsertCustomerVehicle(vehicleCustomerML);

                var policy = new Customer_Vehicle_Policy_ML()
                {
                    Type = ddlType.SelectedItem.Text,
                    CustomerVehicleId = customerVehicleId,
                    CommenceOn = dtCommence.Date,
                    ExpireOn = dtExpire.Date,
                    NaturalDisaster = ddlnatural.SelectedItem.Text,
                    Vandalism = ddlVandalism.SelectedItem.Text,
                    Terrorism = ddlTerrorism.SelectedItem.Text,
                    StrikeRiot = ddlStrikes.SelectedItem.Text,
                    AirBag = ddlAirbag.SelectedItem.Text,
                    PassengerComp = Convert.ToDecimal(txtPasen.Text),
                    Towing = Convert.ToDecimal(txtTow.Text),
                    DriverComp = Convert.ToDecimal(txtDriverCom.Text),
                    status = "Active",
                    empId = 1
                };

                var res = new Policy_BL().InsertCustomerVehiclepolicy(policy);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void btnSelectVehicle_Click(object sender, EventArgs e)
        {
            if (gridVehicles.Selection.Count>0)
            {
               txtVehicleId.Text = gridVehicles.GetSelectedFieldValues("VehicleID")[0].ToString(); 
            }
            
        }
    }
}