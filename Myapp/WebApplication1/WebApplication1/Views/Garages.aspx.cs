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
using System.Drawing;

namespace WebApplication1.Views
{
    public partial class Garages : System.Web.UI.Page
    {
        public Garage_ML GarageEditID;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["EmpId"] == null)
            {
                Response.Redirect("../login.aspx");
                return;
            }
            if (!Page.IsPostBack)
            {
                btnUpdate.Visible = false;
                btnSave.Visible = true;
                GetGarageData();
                errorMsg.Visible = false;
            }
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
            txtEmail.Text = "";
            txtLocation.Text = "";
            txtName.Text = "";
            txtTp.Text = "";
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
                        GarageTP = txtTp.Text,
                        GarageLocation = txtLocation.Text,
                        Email = txtEmail.Text
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
                    txtLocation.Text = (string)gridGarages.GetSelectedFieldValues("GarageLocation")[0];
                    txtTp.Text = (string)gridGarages.GetSelectedFieldValues("GarageTP")[0];
                    txtEmail.Text = (string)gridGarages.GetSelectedFieldValues("Email")[0];
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
            ClearForm();
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#GaragesModal').modal('show')});</script>", false);
        }

        protected void btnUpdate_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new Garage_ML(gridGarages.GetSelectedFieldValues("GarageID")[0].ToString(),
                                            txtLocation.Text, txtName.Text, txtTp.Text, txtEmail.Text);

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

        protected void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void ClearForm()
        {
             txtName.Text="";
             txtTp.Text="";
             txtLocation.Text="";
             txtEmail.Text = "";
        }
    }
}