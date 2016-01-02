using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelLayer;
using ModelLayer.Spareparts;
using BusinessLayer;
using BusinessLayer.Spareparts;

namespace WebApplication1.Views
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ASPxButton1_Click(object sender, EventArgs e)
        {     
            Claim_ML ml = new Claim_ML();
            ml.spareParts = new List<SparepartPayment_ML>();

            for (int i = 0; i < 3; i++)
            {
                ml.spareParts.Add(new SparepartPayment_ML()
                {
                    sparePartId = i,
                    sparePartQty = 2,
                    sparePartCost = 1000
                });
            }
        
                    ml.policyId = 4;
                    ml.location = "Badulla";
                    ml.reason = "Fell asleep";
                    ml.knockedOn = "tree";
                    ml._3rdVehicleNo = "253-3402";
                    ml._3rdOwnerName = "Ishanka";
                    ml._3rdAddress = "199/4, Keppetipola Road,Badulla";
                    ml._3rdContactNo = "0716405220";
                    ml._3rdRenewalDate =DateTime.Now;
                    ml._3rdSpecialNotes = "";
                    ml._3rdVictimName = "Yas";
                    ml._3rdVictimAddress = "";
                    ml._3rdDamageNature = "rear buffer";
                    ml._3rdClaimant = "Ceylinco";
                    ml._3rdAmountClaimed = 0;
                    ml.isDriverOwner = "No";
                    ml.driverName = "Lakshan";
                    ml.driverLicense ="asdasdasd";
                    ml.licenseCat = "A";
                    ml.licenseExpreDate = DateTime.Now;
                    ml.driverNIC = "912701395v";
                    ml.purchaseDate = DateTime.Now;
                    ml.VehicleUsedFor = "Private";
                    ml.rentCompanyName = "";
                    ml.rentAmount = 0;
                    ml.garageCosts = 324234.324f;
                    ml.otherCosts = 324.43f;

            Claim_BL bl = new Claim_BL();
            //bool returValue = bl.insertClaim(ml);
           // ASPxTextBox1.Text = returValue.ToString();
        }

        /*protected void ASPxButton1_Click(object sender, EventArgs e)
        {
            var bm = new SparepartCategory_BL().GetSparepartCategories();
            var cm = new SparepartManufacturer_BL().GetSparepartManufacturers();
            var dm = new Sparepart_BL().GetSpareparts();
        }*/
    }
}