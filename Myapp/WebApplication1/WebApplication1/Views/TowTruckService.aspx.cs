using ModelLayer;
using System;
using System.Collections.Generic;
using System.Web.UI;

namespace WebApplication1.Views.TowTruckService
{
    public partial class TowTruckService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetTowTruckServices();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {

        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridTowTrucks.Selection.Count>0)
                {
                    var id = (Int32)gridTowTrucks.GetSelectedFieldValues("id")[0];
                    txtName.Text = (string)gridTowTrucks.GetSelectedFieldValues("name")[0];
                    txtLocation.Value = (string)gridTowTrucks.GetSelectedFieldValues("location")[0];
                    txtTp.Value = (string)gridTowTrucks.GetSelectedFieldValues("tp")[0];
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
        protected void btnRemove_Click(object sender, EventArgs e)
        {

        }
        protected void txtLocationSearch_TextChanged(object sender, EventArgs e)
        {

        }
        private void GetTowTruckServices()
        {
            var TowTruckServiceList = new List<TowTruckService_ML>();
            TowTruckServiceList.Add(new TowTruckService_ML() { id = 3, name = "PickMe", location = "Badulla", tp = "0716405220",email="isankalakshan@gmail.com" });

            gridTowTrucks.DataSource = TowTruckServiceList;
            gridTowTrucks.DataBind();
            
        }
        private void CloseModal() 
        {
            txtName.Text = "";
            txtLocation.Value = "";
            txtTp.Value = "";
            txtEmail.Value = "";
            ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#TowTruckServiceModal').modal('hide')});</script>", false);
        }

        protected void btnClose_ServerClick(object sender, EventArgs e)
        {
            CloseModal();
        }
    }
}