<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="New_insurance.aspx.cs" Inherits="WebApplication1.New_insurance" %>
<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-user fa-2x"></i>&nbsp;New Insurance
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
    <i class="fa fa-bars"></i>&nbsp;Choose Insurance Type
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <telerik:RadTileList EnableDragAndDrop="false" runat="server" ID="RadTileList1">
    <Groups>
        <telerik:TileGroup>                        
           <telerik:RadImageAndTextTile ID="tlMotorbike" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/records.png"
                Text="Motorbikes">                
            </telerik:RadImageAndTextTile>
            <telerik:RadImageAndTextTile  ID="tlTrishaw" runat="server" Shape="Square" BackColor="#c3c6c3" ImageUrl="~/tiles/vehicles.png"
                Text="Trishaw" NavigateUrl="~/Views/frmNew3wheelStep1.aspx">                
            </telerik:RadImageAndTextTile>                                   
        </telerik:TileGroup>
      </Groups>
      </telerik:RadTileList>
</asp:Content>
