﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Garages.aspx.cs" Inherits="WebApplication1.Views.Garages" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Garages|Online Claim Assisstant</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-wrench"></i>&nbsp;Garages
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">

    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div class="form-inline">
        <button type="button" class="btn btn-primary horizontal-bar" id="btnAdd" runat="server" onserverclick="btnAdd_ServerClick">
            Add
        </button>
        <button type="button" runat="server" class="btn btn-warning horizontal-bar" id="btnEdit" onserverclick="btnEdit_ServerClick">
            Edit
        </button>
        <button type="button" class="btn btn-danger horizontal-bar" data-toggle="modal" data-target="#DeleteModal">
            Remove
        </button>
    </div>

    <div class="modal fade" id="GaragesModal">
        <div class="modal-dialog small">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Garages</h4>
                </div>
                <div class="modal-body">
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label for="txtName" class="col-sm-2 control-label">Name</label>
                            <div class="col-sm-10">                             
                                <asp:TextBox ID="txtName" runat="server" OnTextChanged="txtName_TextChanged" CssClass="form-control"></asp:TextBox>
                                <asp:RegularExpressionValidator runat="server" ControlToValidate="txtName" ValidationGroup="save" ValidationExpression="^[a-zA-Z0-9 ]*$" ErrorMessage="Invalid" ForeColor="#ff0000" Display="Dynamic" />
                                <asp:requiredfieldvalidator errormessage="Required field" controltovalidate="txtname" runat="server" ValidationGroup="save" ForeColor="#ff0000" Display="Dynamic"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtEmail" class="col-sm-2 control-label">Email</label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" CssClass="form-control" ID="txtEmail" />
                                 <asp:RegularExpressionValidator runat="server" ControlToValidate="txtEmail" ValidationGroup="save" ValidationExpression="^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$" ErrorMessage="Invalid Email" ForeColor="#ff0000" Display="Dynamic" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtLocation" class="col-sm-2 control-label">Location</label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" CssClass="form-control" ID="txtLocation" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtTp" class="col-sm-2 control-label">Telephone</label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" CssClass="form-control" ID="txtTp" />
                                 <asp:RegularExpressionValidator runat="server" ControlToValidate="txtTp" ValidationGroup="save" ValidationExpression="^[0-9]*$" ErrorMessage="Name required" ForeColor="#ff0000" Display="Dynamic" />
                                <asp:requiredfieldvalidator errormessage="Required field" controltovalidate="txtTp" runat="server" ValidationGroup="save" ForeColor="#ff0000" Display="Dynamic"/>
                            </div>
                        </div>
                        <div runat="server" class="alert alert-danger" role="alert" id="errorMsg">
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" runat="server" data-dismiss="modal" id="btnClose" onserverclick="btnClose_ServerClick">Close</button>
                    <button type="button" class="btn btn-primary" runat="server" id="btnSave" onserverclick="btnSave_ServerClick" validationgroup="save">Save</button>
                    <button type="button" class="btn btn-primary" runat="server" id="btnUpdate" onserverclick="btnUpdate_ServerClick">Save changes</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <div>
                <br />
                <dx:ASPxTextBox ID="txtLocationSearch" Theme="Metropolis" runat="server" OnTextChanged="txtLocationSearch_TextChanged" AutoPostBack="True" Height="30px" NullText="Enter Location to Search" Width="170px">
                </dx:ASPxTextBox>
                <br />
                <dx:ASPxGridView Theme="Metropolis" ID="gridGarages" KeyFieldName="GarageID" runat="server" AutoGenerateColumns="False" Width="100%">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="GarageID" Visible="false" VisibleIndex="0" Caption="ID">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="GarageName" VisibleIndex="1" Caption="Name">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="GarageLocation" VisibleIndex="2" Caption="Location" SortOrder="Ascending">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="GarageTP" VisibleIndex="3" Caption="Contact No">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="Email" VisibleIndex="3" Caption="Email">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowPager" Position="TopAndBottom">
                        <PageSizeItemSettings Items="10, 20, 50" Visible="true" />
                    </SettingsPager>
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Garages Information" />
                    <SettingsBehavior AllowSelectByRowClick="true" />
                </dx:ASPxGridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <div class="modal fade" id="SelectErrorModal">
        <div class="modal-dialog error">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Error</h4>
                </div>
                <div class="modal-body">
                    <p>Heads up! You have not selected a record to edit.</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary btn-sm" data-dismiss="modal">Ok</button>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="DeleteModal">
        <div class="modal-dialog error">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Error</h4>
                </div>
                <div class="modal-body">
                    <p>Warning! Are you sure you want to delete this record?</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary btn-sm" data-dismiss="modal">No</button>
                    <button type="button" runat="server" class="btn btn-danger btn-sm" data-dismiss="modal" id="btnDelete" onserverclick="btnDelete_ServerClick">Delete</button>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="ErrorModal">
        <div class="modal-dialog error">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Error</h4>
                </div>
                <div id="divError" name="divError" class="modal-body" runat="server">
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary btn-sm" data-dismiss="modal">Ok</button>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
