<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="subMenuTT_Garages.aspx.cs" Inherits="WebApplication1.subMenuTT_Garages" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-cogs fa-2x"></i>&nbsp;Garages & Trow Truck Services
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
    <i class="fa fa-bars"></i>&nbsp;Menu
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <telerik:RadTileList EnableDragAndDrop="false" runat="server" ID="RadTileList1">
    <Groups>
        <telerik:TileGroup>                        
           <telerik:RadImageAndTextTile ID="tlGarages" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/records.png"
                Text="Garages" NavigateUrl="~/Views/Garages.aspx">                
            </telerik:RadImageAndTextTile>
            <telerik:RadImageAndTextTile  ID="tlTT" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/vehicles.png"
                Text="Tow Trucks" NavigateUrl="~/vehicle_spare.aspx">                
            </telerik:RadImageAndTextTile>                                   
        </telerik:TileGroup>
      </Groups>
      </telerik:RadTileList>
</asp:Content>
