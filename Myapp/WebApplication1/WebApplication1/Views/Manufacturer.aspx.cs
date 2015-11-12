using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelLayer;

namespace WebApplication1
{
    public partial class Manufacturers : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetManufacturers();
        }

        protected void btnEdit_ServerClick(object sender, EventArgs e)
        {

        }

        protected void btnClose_ServerClick(object sender, EventArgs e)
        {

        }

        private void GetManufacturers()
        {
            var ManufacturerList = new List<Manufacturer_ML>();
            ManufacturerList.Add(new Manufacturer_ML() { ManufacturerId=3,ManufacturerName="Toyota" });

           gridManufacturers.DataSource = ManufacturerList;
           gridManufacturers.DataBind();

        }
    }
}