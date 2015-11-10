<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Manufacturers.aspx.cs" Inherits="WebApplication1.Manufacturers" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
     <i class="fa fa-cogs fa-2x"></i>&nbsp;Manufacturers
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>

     <div class="form-inline">
        <button type="button" class="btn btn-primary horizontal-bar" data-toggle="modal" data-target="#ManufacturerModal">
            Add
        </button>
        <button type="button" runat="server" class="btn btn-warning horizontal-bar" id="btnEdit" onserverclick="btnEdit_ServerClick">
            Edit
        </button>
        <button type="button" class="btn btn-danger horizontal-bar">
            Remove
        </button>
    </div>

    <div class="modal fade" id="ManufacturerModal">
        <div class="modal-dialog small">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Manufacturer</h4>
                </div>
                <div class="modal-body">
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label for="txtName" class="col-sm-2 control-label">Name</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" runat="server" id="btnClose" onserverclick="btnClose_ServerClick">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>

    <asp:UpdatePanel ID="upManufacturers" runat="server">
        <ContentTemplate>
                        <div>
                <br />
                <dx:ASPxTextBox ID="txtNameSearch" runat="server" AutoPostBack="True" Height="30px" NullText="Enter Name to Search" Width="170px">
                </dx:ASPxTextBox>
                <br />
                <dx:ASPxGridView ID="gridManufacturers" KeyFieldName="ManufacturerId" runat="server" AutoGenerateColumns="False" Width="80%">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="ManufacturerId" VisibleIndex="0" Caption="ID">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="ManufacturerName" VisibleIndex="1" Caption="Name">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowAllRecords" />
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Manufacturers" />
                    <SettingsBehavior AllowSelectByRowClick="true" />
                </dx:ASPxGridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
