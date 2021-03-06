﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Sparepart.aspx.cs" Inherits="WebApplication1.Views.Spareparts" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Spareparts|Online Claim Assisstant</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-cogs"></i>&nbsp;Spareparts
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div class="form-inline">
        <button type="button" class="btn btn-primary horizontal-bar" runat="server" id="btnAdd" onserverclick="btnAdd_ServerClick">
            Add
        </button>
        <button type="button" runat="server" class="btn btn-warning horizontal-bar" name="btnEdit" onserverclick="btnEdit_ServerClick">
            Edit
        </button>
        <button type="button" class="btn btn-danger horizontal-bar" runat="server" id="btnRemove" onserverclick="btnRemove_ServerClick">
            Remove
        </button>
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
                            <label for="txtName" class="col-sm-2 control-label">Model</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                                <asp:RegularExpressionValidator runat="server" ControlToValidate="txtName" ValidationGroup="save" ValidationExpression="^[a-zA-Z0-9 ]*$" ErrorMessage="Invalid" ForeColor="#ff0000" Display="Dynamic" />
                                <asp:requiredfieldvalidator errormessage="Required field" controltovalidate="txtname" runat="server" ValidationGroup="save" ForeColor="#ff0000" Display="Dynamic"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtEmail" class="col-sm-2 control-label">Category</label>
                            <div class="col-sm-10">
                                <asp:DropDownList runat="server" CssClass="form-control" ID="ddlCatogaries">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtLocation" class="col-sm-2 control-label">Manufacturer</label>
                            <div class="col-sm-10">
                                <asp:DropDownList runat="server" CssClass="form-control" ID="ddlManufacturers">
                                </asp:DropDownList>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtTp" class="col-sm-2 control-label">Year</label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" CssClass="form-control" id="txtYear" />
                                <asp:requiredfieldvalidator errormessage="Required field" controltovalidate="txtYear" runat="server" ValidationGroup="save" ForeColor="#ff0000" Display="Dynamic"/>
                            </div>
                        </div>
                        <div class="form-group">
                            <label for="txtTp" class="col-sm-2 control-label">Unit Cost(Rs)</label>
                            <div class="col-sm-10">
                                <asp:TextBox runat="server" CssClass="form-control" id="txtUnitCost" />
                                <asp:RegularExpressionValidator runat="server" ControlToValidate="txtUnitCost" ValidationGroup="save" ValidationExpression="^[0-9]*$" ErrorMessage="Invalid" ForeColor="#ff0000" Display="Dynamic" />
                                <asp:requiredfieldvalidator errormessage="Required field" controltovalidate="txtUnitCost" runat="server" ValidationGroup="save" ForeColor="#ff0000" Display="Dynamic"/>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" runat="server" name="btnClose" onserverclick="btnClose_ServerClick">Close</button>
                    <button type="button" class="btn btn-primary" runat="server" id="btnSave" onserverclick="btnSave_ServerClick">Save</button>
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
                <table>
                    <tr>
                        <td><dx:ASPxTextBox ID="txtSparepartName" Theme="Metropolis" runat="server" AutoPostBack="True" Height="30px" NullText="Enter a model" Width="170px" OnTextChanged="txtSparepartName_TextChanged">
                </dx:ASPxTextBox></td>
                        <td>&nbsp;</td>
                        <td><dx:ASPxTextBox ID="txtManuName" Theme="Metropolis" runat="server" AutoPostBack="True" Height="30px" NullText="Enter a manufacturer" Width="170px" OnTextChanged="txtSparepartName_TextChanged">
                </dx:ASPxTextBox></td>        
                    </tr>
                </table>
                
                
                <br />
                <dx:ASPxGridView ID="gridSpareparts" Theme="Metropolis" KeyFieldName="sparepartId" runat="server" AutoGenerateColumns="False" Width="100%">
                    <Columns>
                        <dx:GridViewDataTextColumn Visible="false" FieldName="sparepartId" VisibleIndex="0" Caption="ID">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="spareCategoryName" VisibleIndex="1" Caption="Category">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="ManufactureName" VisibleIndex="2" Caption="Manufacturer">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="sparepartName" VisibleIndex="3" Caption="Model" SortOrder="Ascending">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="spareparManufacYear" VisibleIndex="4" Caption=" Model Year">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="sparepartUnitCost" PropertiesTextEdit-DisplayFormatString="n2" VisibleIndex="5" Caption="Unit Cost (Rs)">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn  FieldName="spareCategoryId" Visible="false" Caption="">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn  FieldName="ManufactureId" Visible="false"  Caption="">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowPager" Position="TopAndBottom">
                        <PageSizeItemSettings Items="10, 20, 50" Visible="true"/>
                    </SettingsPager>
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Spareparts" />
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
                    <p>Error Occured</p>
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

</asp:Content>
