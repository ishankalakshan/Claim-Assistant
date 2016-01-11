using ModelLayer.Spareparts;
using System;
using BusinessLayer;
using System.Web.UI;

namespace WebApplication1.Views
{
    public partial class SparepartCatergory : System.Web.UI.Page
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
            GetSparepartCatogoriesData();
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new SparepartCategory_ML() { spareCategoryName = txtName.Text };
                new SparepartCategory_BL().AddSparepartCategory(ml);
                GetSparepartCatogoriesData();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            btnUpdate.Visible = true;
            try
            {
                if (gridSparepartCategories.Selection.Count > 0)
                {
                    var id = (Int64)gridSparepartCategories.GetSelectedFieldValues("spareCategoryId")[0];
                    txtName.Text = (string)gridSparepartCategories.GetSelectedFieldValues("spareCategoryName")[0];
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#SparepartCategoryModal').modal('show')});</script>", false);
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

        protected void txtCategorySearch_TextChanged(object sender, EventArgs e)
        {
            GetSparepartCatogoriesData();
        }

        protected void btnClose_ServerClick(object sender, EventArgs e)
        {
            CloseModal();
        }

        protected void btnDelete_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (gridSparepartCategories.Selection.Count > 0)
                {
                    var id = (Int64)gridSparepartCategories.GetSelectedFieldValues("spareCategoryId")[0];
                    var ml = new SparepartCategory_ML()
                    {
                        spareCategoryId = Convert.ToInt32(id)
                    };
                    new SparepartCategory_BL().DeleteSparepartCategory(ml);
                    GetSparepartCatogoriesData();
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

        private void GetSparepartCatogoriesData()
        {
            var ml = new SparepartCategory_ML()
            {
                spareCategoryName = string.IsNullOrEmpty(txtCategorySearch.Text) ? "" : txtCategorySearch.Text
            };

            gridSparepartCategories.DataSource = new SparepartCategory_BL().GetSparepartCategories(ml);
            gridSparepartCategories.DataBind();

        }

        private void CloseModal()
        {
            txtName.Text = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#SparepartCategoryModal').modal('hide')});</script>", false);
        }

        protected void btnUpdate_ServerClick(object sender, EventArgs e)
        {          
            try
            {
                if (gridSparepartCategories.Selection.Count > 0)
                {
                    var id = (Int64)gridSparepartCategories.GetSelectedFieldValues("spareCategoryId")[0];
                    var ml = new SparepartCategory_ML()
                    {
                        spareCategoryId = Convert.ToInt32(id),
                        spareCategoryName = txtName.Text
                    };
                    new SparepartCategory_BL().UpdateSparepartCategory(ml);
                    GetSparepartCatogoriesData();
                    btnUpdate.Visible = false;
                    btnSave.Visible = true;
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