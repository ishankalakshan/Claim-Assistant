using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelLayer;
using BusinessLayer;

namespace WebApplication1.Views
{
    public partial class TestPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTest_Click(object sender, EventArgs e)
        {     
            Claim_ML ml = new Claim_ML();
            ml.spareParts = new sparePart_ML[1];
             /*for (int i = 0; i < 4; i++)
			{
			    sparePart_ML sparepart = new sparePart_ML();
                 sparepart.sparePartId = i;
                 sparepart.sparePartQty = ++i;
                 sparepart.sparePartCost = 1000+i;
                 ml.spareParts[i]=sparepart;
			}  */

            sparePart_ML sparepart = new sparePart_ML();
                 sparepart.sparePartId = 5;
                 sparepart.sparePartQty = 2;
                 sparepart.sparePartCost = 1000;
                        
                    ml.policyId = 1;
                    ml.location = "Badulla";
                    ml.reason = "Fell asleep";
                    ml.knockedON = "tree";
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
                    ml._3rdAmountClaimed = "";
                    ml.isDriverOwner = "No";
                    ml.driverName = "Lakshan";
                    ml.driverLicense ="asdasdasd";
                    ml.licenseCat = "A";
                    ml.licenseExpreDate = DateTime.Now;
                    ml.driverNIC = "912701395v";
                    ml.purchaseDate = DateTime.Now;
                    ml.VehicleUsedFor = "Private";
                    ml.rentCompanyName = "";
                    ml.rentAmount = "";
                    ml.spareParts[0] = sparepart;
                    ml.garageCosts = 324234.324f;
                    ml.otherCosts = 324.43f;

            Claim_BL bl = new Claim_BL();
            bool returValue = bl.insertClaim(ml);
           txtTest.Text = returValue.ToString();
        }
    }
}