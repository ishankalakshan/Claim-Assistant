using System;
using ModelLayer;
using BusinessLayer;

namespace WebApplication1.Views
{
    public partial class Employee : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void btnSave_ServerClick(object sender, EventArgs e)
        {
            AddRecord();
        }
    }
}