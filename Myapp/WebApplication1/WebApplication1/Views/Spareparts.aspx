﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Spareparts.aspx.cs" Inherits="WebApplication1.Views.Spareparts" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-cogs fa-2x"></i>&nbsp;Spareparts
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div class="form-inline">
        <button type="button" class="btn btn-primary horizontal-bar" data-toggle="modal" data-target="#SparepartModal">
            Add
        </button>
        <button type="button" runat="server" class="btn btn-warning horizontal-bar" name="btnEdit" onserverclick="btnEdit_ServerClick">
            Edit
        </button>
        <button type="button" class="btn btn-danger horizontal-bar">
            Remove
        </button>
    </div>

    <div class="modal fade" id="SelectErrorModal">
        <div class="modal-dialog error">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Error</h4>
                </div>
                <div class="modal-body">
                    <p>Error Occured</p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary btn-sm" data-dismiss="modal">Ok</button>
                </div>
            </div>
        </div>
    </div>

    <div class="modal fade" id="SparepartModal">
        <div class="modal-dialog small">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Sparepart Details</h4>
                </div>
                <div class="modal-body">
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label for="txtName" class="col-sm-2 control-label">Name</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtEmail" class="col-sm-2 control-label">Category</label>
                            <div class="col-sm-10">
                                <select class="form-control" id="cmbCategory">
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                </select>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtLocation" class="col-sm-2 control-label">Manufacturer</label>
                            <div class="col-sm-10">
                                <select class="form-control" id="cmbManufacturer">
                                    <option>1</option>
                                    <option>2</option>
                                    <option>3</option>
                                    <option>4</option>
                                    <option>5</option>
                                </select>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtTp" class="col-sm-2 control-label">Year</label>
                            <div class="col-sm-10">
                                <input runat="server" type="text" class="form-control" id="txtYear" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtTp" class="col-sm-2 control-label">Unit Cost(Rs)</label>
                            <div class="col-sm-10">
                                <input runat="server" type="text" class="form-control" id="txtUnitCost" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" runat="server" name="btnClose" onserverclick="btnClose_ServerClick">Close</button>
                    <button type="button" class="btn btn-primary">Save changes</button>
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
                <dx:ASPxTextBox ID="txtSparepartName" runat="server" AutoPostBack="True" Height="30px" NullText="Enter Name to Search" Width="170px">
                </dx:ASPxTextBox>
                <br />
                <dx:ASPxGridView ID="gridSpareparts" KeyFieldName="sparepartId" runat="server" AutoGenerateColumns="False" Width="100%">
                    <Columns>
                        <dx:GridViewDataTextColumn Visible="false" FieldName="sparepartId" VisibleIndex="0" Caption="ID">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="sparepartModel" VisibleIndex="1" Caption="Name" SortOrder="Ascending">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="sparepartCategory" VisibleIndex="2" Caption="Category">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="spareManufacturer" VisibleIndex="3" Caption="Manufacturer">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="spareUnitCost" VisibleIndex="4" Caption="Year">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="spareManufacYear" VisibleIndex="5" Caption="Unit Cost">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowAllRecords" />
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Spareparts" />
                    <SettingsBehavior AllowSelectByRowClick="true" />
                </dx:ASPxGridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
</asp:Content>
