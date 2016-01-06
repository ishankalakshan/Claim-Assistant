using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ModelLayer;
using BusinessLayer;
using System.Timers;
using System.Threading;

namespace WebApplication1.Views
{
    public partial class ClaimRequests : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GetClaimRequests();
        }

        private void GetClaimRequests()
        {
            gridClaimRequests.DataSource = new ClaimRequest_BL().GetClaimRequests(txtStatusSearch.Text);
            gridClaimRequests.DataBind();
        }

        protected void btnRespond_ServerClick(object sender, EventArgs e)
        {
            try
            {
                if (gridClaimRequests.Selection.Count>0)
                {
                    id.Text = gridClaimRequests.GetSelectedFieldValues("id")[0].ToString();
                    var latitude = gridClaimRequests.GetSelectedFieldValues("latitude")[0].ToString();
                    var longitude = gridClaimRequests.GetSelectedFieldValues("longitude")[0].ToString();
                    lblPolicyId.Text = gridClaimRequests.GetSelectedFieldValues("Policy_ID")[0].ToString();
                    lblClient.Text = (string)gridClaimRequests.GetSelectedFieldValues("Client")[0];
                    lblMobile.Text = (string)gridClaimRequests.GetSelectedFieldValues("Mobile")[0];
                    lblStatus.Text = (string)gridClaimRequests.GetSelectedFieldValues("status")[0];
                    lblSubmitTime.Text = (string)gridClaimRequests.GetSelectedFieldValues("submittime")[0].ToString();

                    js.Text = string.Format(@"<script type='text/javascript'>
                          function initialize() {{
                          var map = new google.maps.Map(
                          document.getElementById('map_canvas'), {{
                              center: new google.maps.LatLng({0},{1}),
                              zoom: 15,
                              mapTypeId: google.maps.MapTypeId.ROADMAP
                          }});
                            var marker = new google.maps.Marker({{
                                            position: new google.maps.LatLng({0},{1}),
                                            map: map
                                        }});
                       }}
                google.maps.event.addDomListener(window, 'load', initialize);
                 </script> ", latitude,longitude);

                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#DetailsModal').modal('show')});</script>", false);
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

        protected void btnResponded_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new ClaimRequest_ML()
                {
                    Id=Convert.ToInt32(id.Text),
                    RespondEmployeeId=3,
                    Status = "Responded",
                    RespondTime = DateTime.Now
                };
                var result = new ClaimRequest_BL().UpdateClaimRequest(ml);

                if (result)
                {
                    GetClaimRequests();
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#DetailsModal').modal('hide')});</script>", false);
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        protected void gridClaimRequests_HtmlDataCellPrepared(object sender, DevExpress.Web.ASPxGridViewTableDataCellEventArgs e)
        {
            string value = e.GetValue("status").ToString();
            if (value == "Pending")
                e.Cell.ForeColor = System.Drawing.Color.Red;
        }

        protected void btnFail_ServerClick(object sender, EventArgs e)
        {
            try
            {
                var ml = new ClaimRequest_ML()
                {
                    Id = Convert.ToInt32(id.Text),
                    RespondEmployeeId = 3,
                    Status = "Failed",
                    RespondTime = DateTime.Now
                };
                var result = new ClaimRequest_BL().UpdateClaimRequest(ml);

                if (result)
                {
                    GetClaimRequests();
                    ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), "script", "<script type='text/javascript'>$( document ).ready(function() { $('#DetailsModal').modal('hide')});</script>", false);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        protected void txtStatusSearch_TextChanged(object sender, EventArgs e)
        {
            GetClaimRequests();
        }

        protected void Timer1_Tick(object sender, EventArgs e)
        {
            GetClaimRequests();
        }
       
    }
}