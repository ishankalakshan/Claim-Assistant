<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Policy.aspx.cs" Inherits="WebApplication1.Views.Policy" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Policy|Online Claim Assisstant</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-user"></i>&nbsp;Policy
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
     <asp:ScriptManager runat="server"></asp:ScriptManager>

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <div>
                <br />
                <table border="0">
                    <tr>
                        <td>
                            <dx:ASPxTextBox ID="txtNameSearch" Theme="Metropolis" runat="server" AutoPostBack="True" Height="30px" NullText="Enter Name to Search" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td>
                            <dx:ASPxTextBox ID="txtBranchSearch" Theme="Metropolis" runat="server" AutoPostBack="True" Height="30px" NullText="Enter Branch to Search" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <dx:ASPxGridView ID="gridPolicy" Theme="Metropolis" KeyFieldName="EmpId" runat="server" AutoGenerateColumns="False" Width="100%">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="EmpId" Visible="false" VisibleIndex="0" Caption="ID">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="EmpName" HeaderStyle-HorizontalAlign="Center" VisibleIndex="1" Caption="Name">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="EmpPhone" HeaderStyle-HorizontalAlign="Center" VisibleIndex="2" Caption="Telephone">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="EmpEmail" HeaderStyle-HorizontalAlign="Center" VisibleIndex="3" Caption="Email">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="EmpBranch" HeaderStyle-HorizontalAlign="Center" VisibleIndex="4" Caption="Branch">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowPager" Position="TopAndBottom">
                        <PageSizeItemSettings Items="10, 20, 50" />
                    </SettingsPager>
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Employee Information" />
                    <SettingsBehavior AllowSelectByRowClick="true" />
                </dx:ASPxGridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
