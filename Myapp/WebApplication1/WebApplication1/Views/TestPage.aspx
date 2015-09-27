<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestPage.aspx.cs" Inherits="WebApplication1.Views.TestPage" %>

<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        
    </div>
        <dx:ASPxTextBox ID="txtTest" runat="server" Width="170px"></dx:ASPxTextBox>
        <dx:ASPxButton ID="btnTest" runat="server" OnClick="btnTest_Click" Text="ASPxButton"></dx:ASPxButton>
    </form>
</body>
</html>
