using ModelLayer;
using ModelLayer.Spareparts;
using System;
using System.Collections.Generic;
using System.Web.UI;
using BusinessLayer;

namespace WebApplication1.Views
{
    public partial class Spareparts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnUpdate.Visible = false;
            btnSave.Visible = true;
            GetSpareparts();
            GetManufacturerList();
            GetCategoryList();
        }

        protected void btnClose_ServerClick(object sender, EventArgs e)
        {

        }

        protected void btnEdit_ServerClick(object sender, EventArgs e)
        {
            btnUpdate.Visible = true;
            btnSave.Visible = false;
            try
            {
                if (gridSpareparts.Selection.Count > 0)
                {
                    txtName.Text = (string)gridSpareparts.GetSelectedFieldValues("sparepartName")[0];
                    ddlCatogaries.SelectedValue = gridSpareparts.GetSelectedFieldValues("sparepartCategory")[0].ToString();
                    ddlManufacturers.SelectedValue = gridSpareparts.GetSelectedFieldValues("sparepartManufacturer")[0].ToString();
                    txtUnitCost.Value = gridSpareparts.GetSelectedFieldValues("sparepartUnitCost")[0].ToString();
                    txtYear.Value = (string)gridSpareparts.GetSelectedFieldValues("spareparManufacYear")[0];
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
            try
            {
                var ml = new Sparepart_ML();
                {
                    ml.sparepartModel = string.IsNullOrEmpty(txtSparepartName.Text) ? "" : txtSparepartName.Text;
                    ml.sparepartCategoryName = string.IsNullOrEmpty(txtSparepartName.Text) ? "" : txtSparepartName.Text;
                    ml.spareManufacturerName = string.IsNullOrEmpty(txtSparepartName.Text) ? "" : txtSparepartName.Text;
                    ml.spareManufacYear = string.IsNullOrEmpty(txtSparepartName.Text) ? "" : txtSparepartName.Text;
                };
                gridSpareparts.DataSource = new Sparepart_BL().GetSpareparts(ml);
                gridSpareparts.DataBind();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void CloseModal()
        {
            txtName.Text = "";
            txtUnitCost.Value = "";
            txtYear.Value ="";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#SparepartModal').modal('hide')});</script>", false);
        }

        private void GetManufacturerList()
        {
            try
            {
                var ml = new Manufacturer_ML() { ManufacturerName="" };
                ddlManufacturers.DataTextField = "ManufactureName";
                ddlManufacturers.DataValueField = "ManufactureId";
                ddlManufacturers.DataSource = new Manufacturer_BL().GetManufacturers(ml);
                ddlManufacturers.DataBind();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GetCategoryList()
        {
            try
            {
                var ml = new SparepartCategory_ML() { spareCategoryName = "" };
                ddlCatogaries.DataTextField = "spareCategoryName";
                ddlCatogaries.DataValueField = "spareCategoryId";
                ddlCatogaries.DataSource = new SparepartCategory_BL().GetSparepartCategories(ml);
                ddlCatogaries.DataBind();
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
                var ml = new Sparepart_ML()
                {
                    sparepartId=Convert.ToInt32(gridSpareparts.GetSelectedFieldValues("sparepartId")[0].ToString())
                };
                new Sparepart_BL().DeleteSparepart(ml);
                GetSpareparts();
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
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#SparepartModal').modal('show')});</script>", false);
        }

        protected void btnRemove_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (gridSpareparts.Selection.Count>0)
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

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new Sparepart_ML() 
                {
                    sparepartModel=txtName.Text,
                    sparepartCategory = Convert.ToInt32(ddlCatogaries.SelectedValue),
                    spareManufacturer = Convert.ToInt32(ddlManufacturers.SelectedValue),
                    spareManufacYear = txtYear.Value,
                    spareUnitCost = Convert.ToSingle(txtUnitCost.Value)
                };
                var result = new Sparepart_BL().AddSparepart(ml);
                if (result)
                {
                    GetSpareparts();
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
                var ml = new Sparepart_ML()
                {
                    sparepartId = Convert.ToInt32(gridSpareparts.GetSelectedFieldValues("sparepartId")[0].ToString()),
                    sparepartModel = txtName.Text,
                    sparepartCategory = Convert.ToInt32(ddlCatogaries.SelectedValue),
                    spareManufacturer = Convert.ToInt32(ddlManufacturers.SelectedValue),
                    spareManufacYear = txtYear.Value,
                    spareUnitCost = Convert.ToSingle(txtUnitCost.Value)
                };

                var result = new Sparepart_BL().UpdateSparepart(ml);
                if (result)
                {
                    GetSpareparts();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}