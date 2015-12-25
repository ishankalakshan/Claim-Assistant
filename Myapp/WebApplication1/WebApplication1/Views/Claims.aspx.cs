using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;
using ModelLayer;
using System.Web.UI.HtmlControls;
using System.Globalization;

namespace WebApplication1.Views
{
    public partial class Claims : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetAllClaimsForGrid();
        }

        private void GetAllClaimsForGrid()
        {
            try
            {
                gridClaims.DataSource = new Claim_BL().GetAllClaims();
                gridClaims.DataBind();
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void btnReview_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var claimId = "";
                if (gridClaims.Selection.Count > 0)
                {
                    claimId = gridClaims.GetSelectedFieldValues("claimId")[0].ToString();
                    var dt = new Claim_BL().GetClaimById(Convert.ToInt32(claimId));

                    if (dt.Rows.Count > 0)
                    {
                        SetCustomerDetails(dt);
                        SetVehicleDetails(dt);
                        SetPolicyDetails(dt);
                        SetClaimDetails(dt);
                        SetThirdPartyDetails(dt);
                        SetClaimPaymentDetails(dt);
                        SetSparepareListDetails(dt);
                    }
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#Modal').modal('show')});</script>", false);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void SetCustomerDetails(DataTable dt)
        {
            try
            {
                lblName.Text = dt.Rows[0]["CustomerName"].ToString();
                lblAddress.Text = dt.Rows[0]["CustomerAddress"].ToString();
                lblNic.Text = dt.Rows[0]["NIC"].ToString();
                lblTelephone.Text = dt.Rows[0]["Office"].ToString();
                lblMobile.Text = dt.Rows[0]["Mobile"].ToString();
                lblEmail.Text = dt.Rows[0]["Email"].ToString();
                lblBank.Text = dt.Rows[0]["bank"].ToString();
                lblBranch.Text = dt.Rows[0]["bank_branch"].ToString();
                lblBankAccount.Text = dt.Rows[0]["bankaccount"].ToString();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void SetVehicleDetails(DataTable dt)
        {
            try
            {
                lblManufacturer.Text = dt.Rows[0]["ManufactureName"].ToString();
                lblModel.Text = dt.Rows[0]["Model"].ToString();
                lblYear.Text = dt.Rows[0]["MakeYear"].ToString();
                lblPresentValue.Text = dt.Rows[0]["PresentValue"].ToString();
                lblDutyFreeValue.Text = dt.Rows[0]["DutyFreeValue"].ToString();
                lblRegistrationNo.Text = dt.Rows[0]["RegistrationNo"].ToString();
                lblFinancialRights.Text = dt.Rows[0]["FinancialRights"].ToString();
                lblUsage.Text = dt.Rows[0]["Usage"].ToString();     
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void SetPolicyDetails(DataTable dt)
        {
            try
            {
                lblPolicyId.Text = dt.Rows[0]["Policy_ID"].ToString();
                lblCommenceOn.Text = dt.Rows[0]["commenceOn"].ToString();
                lblExpireOn.Text = dt.Rows[0]["ExpireOn"].ToString();
                lblNaturalDisasterCover.Text = dt.Rows[0]["natural_disaster"].ToString();
                lblTerrorismCover.Text = dt.Rows[0]["tercover"].ToString();
                lblStrikeRiotCover.Text = dt.Rows[0]["strikes_riots_cover"].ToString();
                lblAirBagCover.Text = dt.Rows[0]["air_bag_cover"].ToString();
                lblDriverCompensation.Text = dt.Rows[0]["driver_compensation"].ToString();
                lblPassengerCompensation.Text = dt.Rows[0]["passenger_compensation"].ToString();
                lblTowingCharges.Text = dt.Rows[0]["towing_charges"].ToString();
                lblStatus.Text = dt.Rows[0]["status"].ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void SetClaimDetails(DataTable dt)
        {
            try
            {
                lblLocation.Text = dt.Rows[0]["location"].ToString();
                lblReason.Text = dt.Rows[0]["reason"].ToString();
                lblKnockedOn.Text = dt.Rows[0]["knockedOn"].ToString();
                lblIsDriverOwner.Text = dt.Rows[0]["isDriverOwner"].ToString();
                lblDriverName.Text = dt.Rows[0]["driverName"].ToString();
                lblDriverNic.Text = dt.Rows[0]["driverNIC"].ToString();
                lblLicense.Text = dt.Rows[0]["licenceNo"].ToString();
                lblDebitOutstanding.Text = dt.Rows[0]["debitOutstanding"].ToString();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void SetThirdPartyDetails(DataTable dt)
        {
            try
            {
                lblVehicleNo.Text = dt.Rows[0]["vehicleRegistrationNo"].ToString();
                lblOwner.Text = dt.Rows[0]["ownerName"].ToString();
                lblThirdpartyAddress.Text = dt.Rows[0]["ownerAddress"].ToString();
                lblNotes.Text = dt.Rows[0]["specialNotes"].ToString();
                lblVictimName.Text = dt.Rows[0]["victimName"].ToString();
                lblVictimAddress.Text = dt.Rows[0]["victimAddress"].ToString();
                lblDamages.Text = dt.Rows[0]["damageNature"].ToString();
                lblClaimant.Text = dt.Rows[0]["thirdPartyClaimant"].ToString();
                lblClaimantAmount.Text = dt.Rows[0]["claimAmount"].ToString();

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void SetClaimPaymentDetails(DataTable dt)
        {
            try
            {
                var cultureInfo = new CultureInfo("hi-IN");
                var numberFormatInfo = (NumberFormatInfo)cultureInfo.NumberFormat.Clone();
                numberFormatInfo.CurrencySymbol = "Rs";

                lblGarageCosts.Text = Convert.ToDecimal(dt.Rows[0]["garageCost"]).ToString("C", numberFormatInfo);
                lblOtherCosts.Text = Convert.ToDecimal(dt.Rows[0]["otherCosts"].ToString()).ToString("C", numberFormatInfo);
                lblDeductions.Text = Convert.ToDecimal(dt.Rows[0]["deductions"].ToString()).ToString("C", numberFormatInfo);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void SetSparepareListDetails(DataTable dt)
        {
            var cultureInfo = new CultureInfo("hi-IN");
            var numberFormatInfo = (NumberFormatInfo)cultureInfo.NumberFormat.Clone();
            numberFormatInfo.CurrencySymbol = "Rs";

            try
            {               
                gridSpareparts.DataSource = dt;
                gridSpareparts.DataBind();
                double totalsparecost = 0;
                double totalcost = 0;
                double GarageCosts = 0;
                double OtherCosts = 0;
                double Deductions = 0;

                if (dt.Rows[0]["garageCost"]!=null)
                {
                    GarageCosts = Convert.ToDouble(dt.Rows[0]["garageCost"].ToString());
                }
                if (dt.Rows[0]["otherCosts"]!=null)
                {
                    OtherCosts = Convert.ToDouble(dt.Rows[0]["otherCosts"].ToString());
                }
                if (dt.Rows[0]["deductions"].ToString() != null)
                {
                    Deductions = Convert.ToDouble(dt.Rows[0]["deductions"].ToString());
                }
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    var unitPrice = Convert.ToDouble(dt.Rows[i]["sparePartCost"].ToString());
                    var Qty = Convert.ToInt32(dt.Rows[i]["sparepartQty"].ToString());

                    totalsparecost += (unitPrice * Qty);      
                }
                totalcost = totalsparecost + GarageCosts + OtherCosts - Deductions;
                lblPayable.Text = Convert.ToDecimal(totalcost).ToString("C", numberFormatInfo); 
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}