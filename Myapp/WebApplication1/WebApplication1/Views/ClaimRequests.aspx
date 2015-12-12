<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ClaimRequests.aspx.cs" Inherits="WebApplication1.Views.ClaimRequests" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
     <i class="fa fa-user"></i>&nbsp;Employees
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
     <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div class="form-inline">
        <button type="button" class="btn btn-primary horizontal-bar" data-toggle="modal" data-target="#EmployeeModal">
            Map
        </button>
        <button type="button" runat="server" class="btn btn-warning horizontal-bar" id="btnEdit">
            Edit
        </button>
        <button type="button" class="btn btn-danger horizontal-bar" data-toggle="modal" data-target="#DeleteModal">
            Remove
        </button>
    </div>

</asp:Content>
