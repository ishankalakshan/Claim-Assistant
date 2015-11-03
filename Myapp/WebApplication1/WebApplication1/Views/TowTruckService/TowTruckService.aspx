<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TowTruckService.aspx.cs" Inherits="WebApplication1.Views.TowTruckService.TowTruckService" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-cogs fa-2x"></i>&nbsp;Tow Truck Services
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div class="btn-toolbar" role="toolbar">
        <div class="btn-group" role="group">
            <div class="btn-group" role="group">
                <button class="btn btn-default horizontal-bar" name="btnAdd" onclick="btnAdd_Click">Add</button>
            </div>
            <div class="btn-group" role="group">
                <button class="btn btn-default horizontal-bar" name="btnEdit" value="Edit" onclick="btnEdit_Click">Edit</button>
            </div>
            <div class="btn-group" role="group">
                <button class="btn btn-default horizontal-bar" name="btnRemove" value="Remove" onclick="btnRemove_Click">Remove</button>
            </div>
        </div>
    </div>

</asp:Content>
