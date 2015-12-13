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
            View
        </button>
    </div>

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <div>
                <br />
                <table border="0">
                    <tr>
                        <td>
                            <dx:ASPxTextBox ID="txtStatusSearch" runat="server" AutoPostBack="True" Height="30px" NullText="Enter status Search" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <dx:ASPxGridView ID="gridClaimRequests" KeyFieldName="id" runat="server" AutoGenerateColumns="False" Width="100%">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="id" Visible="false" VisibleIndex="0" Caption="ID">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Policy_ID" VisibleIndex="1" Caption="PolicyId">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Client" VisibleIndex="2" Caption="Client">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Mobile" VisibleIndex="3" Caption="Telephone">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="status" VisibleIndex="4" Caption="Status">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="submittime" VisibleIndex="5" Caption="Submit">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="respondtime" VisibleIndex="6" Caption="Respond">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowPager" />
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Claim Requests" />
                    <SettingsBehavior AllowSelectByRowClick="true" AllowSelectSingleRowOnly="true" />
                </dx:ASPxGridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
