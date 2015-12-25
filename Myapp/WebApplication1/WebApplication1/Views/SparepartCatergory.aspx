<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="SparepartCatergory.aspx.cs" Inherits="WebApplication1.Views.SparepartCatergory" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-list-alt"></i>&nbsp;Sparepart Category
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <div class="form-inline">
        <button type="button" class="btn btn-primary horizontal-bar" data-toggle="modal" data-target="#SparepartCategoryModal">
            Add
        </button>
        <button type="button" runat="server" class="btn btn-warning horizontal-bar" name="btnEdit" onserverclick="btnEdit_Click">
            Edit
        </button>
        <button type="button" runat="server" class="btn btn-danger horizontal-bar" data-toggle="modal" data-target="#DeleteModal">
            Delete
        </button>
    </div>

    <div class="modal fade" id="SparepartCategoryModal">
        <div class="modal-dialog small">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Sparepart Catergory</h4>
                </div>
                <div class="modal-body">
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label for="txtName" class="col-sm-2 control-label">Category Name</label>
                            <div class="col-sm-10">
                                <asp:TextBox ID="txtName" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" runat="server" id="btnClose" onserverclick="btnClose_ServerClick">Close</button>
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
                <dx:ASPxTextBox ID="txtCategorySearch" OnTextChanged="txtCategorySearch_TextChanged" runat="server" AutoPostBack="True" Height="30px" NullText="Enter name to search" Width="170px">
                </dx:ASPxTextBox>
                <br />
                <dx:ASPxGridView ID="gridSparepartCategories" KeyFieldName="spareCategoryId" runat="server" AutoGenerateColumns="False" Width="80%">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="spareCategoryId" CellStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" VisibleIndex="0" Caption="ID">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="spareCategoryName" CellStyle-HorizontalAlign="Center" HeaderStyle-HorizontalAlign="Center" VisibleIndex="1" Caption="Name">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsEditing EditFormColumnCount="3" Mode="PopupEditForm" />
                    <SettingsPopup>
                        <EditForm Width="800" />
                    </SettingsPopup>
                    <SettingsPager Mode="ShowAllRecords" />
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Sparepart Category Information" />
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

</asp:Content>
