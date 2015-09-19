<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.WebForm1" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-home fa-2x"></i>&nbsp;Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpFprmContaintName" runat="server">
    <i class="fa fa-bars"></i>&nbsp;Main Menu
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    
    <telerik:RadTileList EnableDragAndDrop="false" runat="server" ID="RadTileList1">
    <Groups>
        <telerik:TileGroup>            
            <telerik:RadImageAndTextTile runat="server" Id="tlNew_insurance" BackColor="#c3c6c3" ImageUrl="~/tiles/New_insurance.png" Shape="Wide"
                Text="New Insurarance" NavigateUrl="~/New_insurance.aspx">                              
            </telerik:RadImageAndTextTile>
           <telerik:RadImageAndTextTile ID="tlView_Records" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/records.png"
                Text="View Inusurance Records">                
            </telerik:RadImageAndTextTile>
            <telerik:RadImageAndTextTile  ID="tlVehicles1" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/vehicles.png"
                Text="Vehicles & Spare Parts" NavigateUrl="~/vsMenu.aspx">                
            </telerik:RadImageAndTextTile>                       
            <telerik:RadImageAndTextTile  ID="tlTrow_truck" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/towtruck.png"
                Text="Tow Truck & Garage Services" NavigateUrl="subMenuTT_Garages.aspx">                
            </telerik:RadImageAndTextTile>
        </telerik:TileGroup>

        <telerik:TileGroup>
            <telerik:RadImageAndTextTile ID="tlClaims" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/claims_squre.png"
                Text="Claims">                
            </telerik:RadImageAndTextTile>
            <telerik:RadImageAndTextTile  ID="tlReports" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/reports.png"
                Text="Reports">                
            </telerik:RadImageAndTextTile>
        </telerik:TileGroup>

        <telerik:TileGroup>
            <telerik:RadImageAndTextTile ID="tlAdministration" runat="server" Shape="Wide" BackColor="#c3c6c3" ImageUrl="~/tiles/admin_wide.png"
                Text="Administration">                
            </telerik:RadImageAndTextTile>                        
            <telerik:RadImageAndTextTile ID="tlHelp" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/help_square.png"
                Text="Help">                
            </telerik:RadImageAndTextTile>
        </telerik:TileGroup>
       
    </Groups>

    </telerik:RadTileList>
</asp:Content>

