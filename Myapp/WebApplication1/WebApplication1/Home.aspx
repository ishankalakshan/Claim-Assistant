<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-home fa-2x"></i>&nbsp;Home
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpFprmContaintName" runat="server">
    <i class="fa fa-bars"></i>&nbsp;Main Menu
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <a href="New_insurance.aspx">content</a>
    <a href="vsMenu.aspx">content</a>
    <a href="subMenuTT_Garages.aspx">content</a>
    <a href="New_insurance.aspx">content</a>
    <a href="New_insurance.aspx">content</a>
    <a href="New_insurance.aspx">content</a>
</asp:Content>

