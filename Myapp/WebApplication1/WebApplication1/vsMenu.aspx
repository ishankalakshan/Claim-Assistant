<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="vsMenu.aspx.cs" Inherits="WebApplication1.vsMenu" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-truck fa-2x"></i>&nbsp;Vehicles & Spare Parts
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
    <i class="fa fa-bars"></i>&nbsp;Menu
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <telerik:RadTileList EnableDragAndDrop="false" runat="server" ID="RadTileList1">
    <Groups>
        <telerik:TileGroup>                        
           <telerik:RadImageAndTextTile ID="tlVehicles" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/records.png"
                Text="Vehicles" NavigateUrl="~/vehicle_spare.aspx">                
            </telerik:RadImageAndTextTile>
            <telerik:RadImageAndTextTile  ID="tlSpareParts" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/vehicles.png"
                Text="Spare Parts" NavigateUrl="#">                
            </telerik:RadImageAndTextTile>                                   
        </telerik:TileGroup>
      </Groups>
      </telerik:RadTileList>
</asp:Content>
