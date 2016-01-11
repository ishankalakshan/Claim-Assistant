using ModelLayer;
using System;
using System.Collections.Generic;
using System.Web.UI;
using BusinessLayer;

namespace WebApplication1.Views.TowTruckService
{
    public partial class TowTruckService : System.Web.UI.Page
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
            GetTowTruckServices();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#TowTruckServiceModal').modal('show')});</script>", false);
            
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                btnSave.Visible = false;
                btnUpdate.Visible = true;
                if (gridTowTrucks.Selection.Count > 0)
                {
                    var id = (Int32)gridTowTrucks.GetSelectedFieldValues("Id")[0];
                    txtName.Text = (string)gridTowTrucks.GetSelectedFieldValues("name")[0];
                    txtLocation.Value = (string)gridTowTrucks.GetSelectedFieldValues("location")[0];
                    txtTp.Value = (string)gridTowTrucks.GetSelectedFieldValues("telephone")[0];
                    txtEmail.Value = (string)gridTowTrucks.GetSelectedFieldValues("email")[0];
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#TowTruckServiceModal').modal('show')});</script>", false);
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

        protected void txtLocationSearch_TextChanged(object sender, EventArgs e)
        {
            GetTowTruckServices();
        }

        protected void btnClose_ServerClick(object sender, EventArgs e)
        {
            CloseModal();
        }

        private void GetTowTruckServices()
        {
            try
            {
                var ml = new TowTruckService_ML()
                { 
                    location=string.IsNullOrEmpty(txtLocationSearch.Text) ? "" : txtLocationSearch.Text
                };
                gridTowTrucks.DataSource = new TowTruckService_BL().GetTowTruckServices(ml);
                gridTowTrucks.DataBind();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CloseModal()
        {
            txtName.Text = "";
            txtLocation.Value = "";
            txtTp.Value = "";
            txtEmail.Value = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#TowTruckServiceModal').modal('hide')});</script>", false);
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                 var ml = new TowTruckService_ML()
                {
                    name = txtName.Text,
                    tp = txtTp.Value,
                    location = txtLocation.Value,
                    email = txtEmail.Value
                };
                 var result = new TowTruckService_BL().AddTowTruckService(ml);
                if (result)
                {
                    GetTowTruckServices();
                }
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
                 var ml = new TowTruckService_ML(gridTowTrucks.GetSelectedFieldValues("Id")[0].ToString(),txtName.Text,txtLocation.Value,txtTp.Value,txtEmail.Value);

                 var result = new TowTruckService_BL().UpdateTowTruckService(ml);
                if (result)
                {
                    GetTowTruckServices();
                }
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
                if (gridTowTrucks.Selection.Count > 0)
                {
                    var id = (Int32)gridTowTrucks.GetSelectedFieldValues("Id")[0];
                    var ml = new TowTruckService_ML()
                    {
                        id = id
                    };
                    new TowTruckService_BL().DeleteTowTruckService(ml);
                    GetTowTruckServices();
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