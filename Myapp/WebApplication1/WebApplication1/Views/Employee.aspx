<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WebApplication1.Views.Employee" %>

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
            Add
        </button>
        <button type="button" runat="server" class="btn btn-warning horizontal-bar" id="btnEdit" onserverclick="btnEdit_ServerClick">
            Edit
        </button>
        <button type="button" class="btn btn-danger horizontal-bar" data-toggle="modal" data-target="#DeleteModal">
            Remove
        </button>
    </div>

    <div class="modal fade" id="EmployeeModal">
        <div class="modal-dialog small">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Employee Details</h4>
                </div>
                <div class="modal-body">
                    <div class="form-horizontal">
                        <div class="form-group">
                            <label class="col-sm-2 control-label">Name</label>
                            <div class="col-sm-10">
                                <input runat="server" type="text" class="form-control" id="txtName" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">Mobile</label>
                            <div class="col-sm-10">
                                <input runat="server" type="number" class="form-control" id="txtMobile" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">Email</label>
                            <div class="col-sm-10">
                                <input runat="server" type="email" class="form-control" id="txtEmail" />
                            </div>
                        </div>
                        <div class="form-group">
                            <label class="col-sm-2 control-label">Branch</label>
                            <div class="col-sm-10">
                                <input runat="server" type="text" class="form-control" id="txtBranch" />
                            </div>
                        </div>
                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal" id="btnClose" runat="server" onserverclick="btnClose_ServerClick">Close</button>
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
                <table border="0">
                    <tr>
                        <td>
                            <dx:ASPxTextBox ID="txtNameSearch" runat="server" AutoPostBack="True" Height="30px" NullText="Enter Name to Search" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                        <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                        <td>
                            <dx:ASPxTextBox ID="txtBranchSearch" runat="server" AutoPostBack="True" Height="30px" NullText="Enter Branch to Search" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <dx:ASPxGridView ID="gridEmployees" KeyFieldName="EmpId" runat="server" AutoGenerateColumns="False" Width="100%">
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
                    <SettingsPager Mode="ShowAllRecords" />
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Employee Information" />
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
