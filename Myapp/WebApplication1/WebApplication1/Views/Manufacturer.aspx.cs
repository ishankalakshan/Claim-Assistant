using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelLayer;
using BusinessLayer;

namespace WebApplication1
{
    public partial class Manufacturers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            GetManufacturers();
        }

        private void GetManufacturers()
        {
            try
            {
                var ml = new Manufacturer_ML();
                {
                    ml.ManufacturerName = string.IsNullOrEmpty(txtNameSearch.Text) ? "" : txtNameSearch.Text;
                };
                gridManufacturers.DataSource = new Manufacturer_BL().GetManufacturers(ml);
                gridManufacturers.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void CloseModal()
        {
            txtName.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#ManufacturerModal').modal('hide')});</script>", false);
        }

        protected void btnEdit_ServerClick(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            try
            {
                if (gridManufacturers.Selection.Count > 0)
                {
                    txtName.Text = (string)gridManufacturers.GetSelectedFieldValues("ManufactureName")[0];
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#ManufacturerModal').modal('show')});</script>", false);
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

        protected void btnClose_ServerClick(object sender, EventArgs e)
        {
            CloseModal();
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new Manufacturer_ML() { ManufacturerName = txtName.Text };
                var result = new Manufacturer_BL().AddManufacturer(ml);
                if (result)
                {
                    GetManufacturers();
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
                var ml = new Manufacturer_ML(gridManufacturers.GetSelectedFieldValues("ManufactureId")[0].ToString(),
                                            txtName.Text);

                var result = new Manufacturer_BL().UpdateManufacturer(ml);
                if (result)
                {
                    GetManufacturers();
                }
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
            txtName.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#ManufacturerModal').modal('show')});</script>", false);
        }

        protected void btnDelete_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (gridManufacturers.Selection.Count > 0)
                {
                    var id = (Int32)gridManufacturers.GetSelectedFieldValues("ManufactureId")[0];
                    var ml = new Manufacturer_ML()
                    {
                        ManufacturerId = id
                    };
                    new Manufacturer_BL().DeleteManufacturer(ml);
                    GetManufacturers();
                }
                else
                {
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#SelectErrorModal').modal('show')});</script>", false);
                }
            }
            catch
            {
                throw;
            }

        }

    }
}