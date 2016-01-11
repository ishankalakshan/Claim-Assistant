using System;
using ModelLayer;
using BusinessLayer;
using System.Web.UI;

namespace WebApplication1.Views
{
    public partial class Employee : System.Web.UI.Page
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
            GetEmployees();
        }

        private void AddRecord() 
        {
            try
            {
                var ml = new Employee_ML()
                {
                    EmpName = txtName.Value,
                    EmpPhone = txtMobile.Value,
                    EmpEmail = txtEmail.Value,
                    EmpBranch = txtBranch.Value
                };
                var result = new Employee_BL().AddEmployee(ml);
                if (result)
                {
                    GetEmployees();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void GetEmployees()
        {
            var ml = new Employee_ML()
            {
                EmpName = string.IsNullOrEmpty(txtNameSearch.Text) ? "" : txtNameSearch.Text,
                EmpBranch = string.IsNullOrEmpty(txtBranchSearch.Text) ? "" : txtBranchSearch.Text
            };

            gridEmployees.DataSource = new Employee_BL().GetEmployees(ml);
            gridEmployees.DataBind();

        }

        private void CloseModal()
        {
            txtName.Value = "";
            txtEmail.Value = "";
            txtMobile.Value = "";
            txtBranch.Value = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#EmployeeModal').modal('hide')});</script>", false);
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            AddRecord();
        }

        protected void btnDelete_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (gridEmployees.Selection.Count > 0)
                {
                    var id = (Int32)gridEmployees.GetSelectedFieldValues("EmpId")[0];
                    var ml = new Employee_ML()
                    {
                        EmpId = Convert.ToInt32(id)
                    };
                    new Employee_BL().DeleteEmployee(ml);
                    GetEmployees();
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

        protected void btnUpdate_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new Employee_ML()
                {
                    EmpId = (Int32)gridEmployees.GetSelectedFieldValues("EmpId")[0],
                    EmpName = txtName.Value,
                    EmpPhone = txtMobile.Value,
                    EmpEmail = txtEmail.Value,
                    EmpBranch = txtBranch.Value
                };
                var result = new Employee_BL().UpdateEmployee(ml);
                if (result)
                {
                    GetEmployees();
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
                if (gridEmployees.Selection.Count > 0)
                {
                    var id = (Int32)gridEmployees.GetSelectedFieldValues("EmpId")[0];
                    txtName.Value = (string)gridEmployees.GetSelectedFieldValues("EmpName")[0];
                    txtEmail.Value = (string)gridEmployees.GetSelectedFieldValues("EmpEmail")[0];
                    txtMobile.Value = (string)gridEmployees.GetSelectedFieldValues("EmpPhone")[0];
                    txtBranch.Value = (string)gridEmployees.GetSelectedFieldValues("EmpBranch")[0];
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#EmployeeModal').modal('show')});</script>", false);
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
    }
}