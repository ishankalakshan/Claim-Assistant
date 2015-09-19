<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmAddGarage.aspx.cs" Inherits="WebApplication1.Views.frmAddGarage" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-cogs fa-2x"></i>&nbsp;Garages
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
    <i class="fa fa-plus"></i>&nbsp;Add New Garage
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="4" ShowItemCaptionColon="False" AlignItemCaptionsInAllGroups="True" Width="500px">
        <Items>
            <dx:LayoutItem Caption="Garage Name" ColSpan="4" RequiredMarkDisplayMode="Required">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                        <dx:ASPxTextBox ID="txtGarageName" runat="server" Height="25px" Width="100%" 
                            OnValidation="txtGarageName_Validation" EnableClientSideAPI="True">
                            <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                                <RequiredField IsRequired="True"/>
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>       
            <dx:LayoutItem Caption="Location" ColSpan="4" RequiredMarkDisplayMode="Required">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                        <dx:ASPxTextBox ID="txtGarageLocation" runat="server" Height="25px" Width="100%">
                            <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom">
                                <RequiredField IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Telephone" ColSpan="4" RequiredMarkDisplayMode="Required">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                        <dx:ASPxTextBox ID="txtGarageTP" runat="server" Height="25px" Width="100%">
                            <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom">
                                <RequiredField IsRequired="True" />
                            </ValidationSettings>
                        </dx:ASPxTextBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem> 
            <dx:EmptyLayoutItem ColSpan="4">
            </dx:EmptyLayoutItem>
            <dx:LayoutItem Caption="&nbsp;" HorizontalAlign="Right" ColSpan="4" Width="100%">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                        <div style="float: left;">
                            <dx:ASPxButton ID="btnSave" runat="server" Height="25px" Text="Save" OnClick="btnSave_Click" ValidationGroup="Gr1">
                            </dx:ASPxButton>
                        </div>
                        <div style="float: left; padding-left: 10px;">
                            <dx:ASPxButton ID="btnCancel" runat="server" Height="25px" Text="Cancel" UseSubmitBehavior="False" ValidateRequestMode="Disabled">
                            </dx:ASPxButton>
                        </div>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>         
        </Items>
        <SettingsItemCaptions VerticalAlign="Middle" />
        <Styles>
            <LayoutItem>
                <Paddings PaddingTop="15px" />
            </LayoutItem>
        </Styles>
    </dx:ASPxFormLayout>
    
</asp:Content>

