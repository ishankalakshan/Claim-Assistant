<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="vehicle_spare.aspx.cs" Inherits="WebApplication1.vehicle_spare" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
   <i class="fa fa-taxi fa-2x"></i>&nbsp;Vehicles
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    
    <form id="frmVehicle_Spare" role="form">
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <div class="form-group">
                    <div class="btn-group" role="group" aria-label="...">
                      <button type="button" class="btn btn-primary" data-toggle="modal" data-target="#myModal">Add</button>
                      
                      <asp:Button CssClass="btn btn-default" ID="btnEdit" runat="server" Text="Edit" />
                      <asp:Button CssClass="btn btn-default" ID="btnRemove" runat="server" Text="Remove"/>
                     </div>                    
                </div>
                <!-- Modal -->
                <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel" aria-hidden="true">
                  <div class="modal-dialog">
                    <div class="modal-content">
                      <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" id="myModalLabel">Add New Vehicle</h4>
                      </div>
                      <div class="modal-body">
                           <form id="Form1" role="form"></form>
                         <div class="form-group">
                           <label>Manufacturer</label>
                           <asp:TextBox ID="tbId" placeholder="VehicleID" required="true" runat="server" Visible="False"></asp:TextBox>
                           <asp:TextBox CssClass="form-control" ID="tbManufacturer" placeholder="Manufacturer" required="true" runat="server"></asp:TextBox>
                         </div>
                          <div class="form-group">
                           <label>Model</label>                   
                             <asp:TextBox CssClass="form-control" ID="txtModel" placeholder="Model" required="true" runat="server"></asp:TextBox>                  
                         </div>
                          <div class="form-group">
                           <label>Model</label>
                           <asp:TextBox ID="tbModel" placeholder="Model" required="true" runat="server" CssClass="form-control"></asp:TextBox>
                         </div>
                          <div class="form-group">
                           <label>Fuel Type</label>
                           <asp:TextBox ID="tbFuel_type" placeholder="Fuel Type" required="true" runat="server" CssClass="form-control"></asp:TextBox>
                         </div>
                          <div class="form-group">
                              <label>Color</label>
                              <asp:TextBox ID="txtColor" placeholder="Color" required="true" runat="server" CssClass="form-control"></asp:TextBox>
                          </div>
                          <div class="form-group">
                           <label>Year</label>
                           <asp:TextBox ID="txtYear" placeholder="Year" required="true" runat="server" CssClass="form-control"></asp:TextBox>
                         </div>
                          <div class="form-group">
                           <label>Cylinder Capacity</label>
                           <asp:TextBox ID="txtCCapacity" placeholder="Cylinder Capacity" required="true" runat="server" CssClass="form-control"></asp:TextBox>
                         </div>
                          <div class="form-group">
                           <label>Seats(With Driver)</label>
                           <asp:TextBox ID="txtSeats" TextMode="Number" placeholder="Seats(With Driver)" required="true" runat="server" CssClass="form-control"></asp:TextBox>
                         </div>
                          <div class="form-group">
                           <label>Carrying Capacity</label>
                           <asp:TextBox ID="txtCarrying" TextMode="Number" placeholder="Carrying Capacity" required="true" runat="server" CssClass="form-control"></asp:TextBox>
                         </div>
                          <div class="form-group">
                           <label>Current Market Value</label>
                           <asp:TextBox ID="txtMarketValue" TextMode="Number" placeholder="Current Market Value" required="true" runat="server" CssClass="form-control"></asp:TextBox>
                         </div>
                      </div>
                    </form>
                      <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                        <button type="button" class="btn btn-primary">Save changes</button>
                      </div>
                    </div>
                  </div>
                </div>
                <div class="form-group">
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
        </form>


    <script>
        $('#myModal').on('shown.bs.modal', function () {
            $('#myInput').focus()
        })
    </script>


</asp:Content>
