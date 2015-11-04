<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Garages.aspx.cs" Inherits="WebApplication1.Views.Garages" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-cogs fa-2x"></i>&nbsp;Garages
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">

    <asp:ScriptManager runat="server"></asp:ScriptManager>

   <div class="btn-group" role="group">
     <div class="btn-group" role="group"><dx:ASPxButton runat="server" Text="Add" ID="btnAdd" OnClick="btnAdd_Click"/></div>
     <div class="btn-group" role="group"><dx:ASPxButton runat="server" Text="Edit" ID="btnEdit" OnClick="btnEdit_Click"/></div>
     <div class="btn-group" role="group"><dx:ASPxButton runat="server" Text="Remove" ID="btnRemove" OnClick="btnRemove_Click"/></div>
    </div>
    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <div>
                    <br />
                    <dx:ASPxTextBox ID="txtLocationSearch" runat="server" OnTextChanged="txtLocationSearch_TextChanged" AutoPostBack="True" Height="30px" NullText="Enter Location to Search" Width="170px">
                    </dx:ASPxTextBox>
                    <br />
                    <dx:ASPxGridView ID="gridGarages" KeyFieldName="GarageID"  runat="server" AutoGenerateColumns="False" Width="100%">
                        <Columns>                          
                            <dx:GridViewDataTextColumn FieldName="GarageID" VisibleIndex="0" Caption="ID">                              
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="GarageName" VisibleIndex="1" Caption="Name">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="GarageLocation" VisibleIndex="2" Caption="Location" SortOrder="Ascending">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="GarageTP" VisibleIndex="3" Caption="Contact No">
                            </dx:GridViewDataTextColumn>                
                        </Columns>    
                        <SettingsEditing EditFormColumnCount="3" Mode="PopupEditForm" />
                        <SettingsPopup>
                          <EditForm Width="800"/>
                        </SettingsPopup>
                        <SettingsPager Mode="ShowAllRecords" />
                        <Settings ShowTitlePanel="true" />
                        <SettingsText Title="Garages Information" />
                        <SettingsBehavior AllowSelectByRowClick="true" />                  
                    </dx:ASPxGridView>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
