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
        public Garage_ML GarageEditID;

        protected void Page_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            GetGarageData();
        }

        private void GetGarageData()
        {
            try
            {
                var ml = new Garage_ML();
                {
                    ml.GarageLocation = string.IsNullOrEmpty(txtLocationSearch.Text) ? "" : txtLocationSearch.Text;
                };

                gridGarages.DataSource = new Garage_BL().GetGarageData(ml);
                gridGarages.DataBind();
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void CloseModal()
        {
            txtEmail.Value = "";
            txtLocation.Value = "";
            txtName.Text = "";
            txtTp.Value = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#GaragesModal').modal('hide')});</script>", false);
        }

        protected void txtLocationSearch_TextChanged(object sender, EventArgs e)
        {
            GetGarageData();
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new Garage_ML()
                {
                    GarageName = txtName.Text,
                    GarageTP = txtTp.Value,
                    GarageLocation = txtLocation.Value,
                    Email = txtEmail.Value
                };
                var result = new Garage_BL().AddGarage(ml);
                if (result)
                {
                    GetGarageData();
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
                if (gridGarages.Selection.Count > 0)
                {
                    var id = (Int32)gridGarages.GetSelectedFieldValues("GarageID")[0];
                    var ml = new Garage_ML()
                    {
                        GarageID = id
                    };
                    new Garage_BL().DeleteGarage(ml);
                    GetGarageData();
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
                if (gridGarages.Selection.Count > 0)
                {
                    txtName.Text = (string)gridGarages.GetSelectedFieldValues("GarageName")[0];
                    txtLocation.Value = (string)gridGarages.GetSelectedFieldValues("GarageLocation")[0];
                    txtTp.Value = (string)gridGarages.GetSelectedFieldValues("GarageTP")[0];
                    txtEmail.Value = (string)gridGarages.GetSelectedFieldValues("Email")[0];
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#GaragesModal').modal('show')});</script>", false);
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

        protected void btnAdd_ServerClick(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#GaragesModal').modal('show')});</script>", false);
        }

        protected void btnUpdate_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new Garage_ML(gridGarages.GetSelectedFieldValues("GarageID")[0].ToString(),
                                            txtLocation.Value, txtName.Text, txtTp.Value, txtEmail.Value);

                var result = new Garage_BL().UpdateGarage(ml);
                if (result)
                {
                    GetGarageData();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnClose_ServerClick(object sender, EventArgs e)
        {
            CloseModal();
        }
    }
}