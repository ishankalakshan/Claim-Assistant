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

    <div class="form-inline">
        <button type="button" class="btn btn-primary horizontal-bar" data-toggle="modal" data-target="#PolicyModal">
            Add
        </button>
        <%--<button type="button" runat="server" class="btn btn-warning horizontal-bar" id="btnEdit">
            Update
        </button>
        <button type="button" class="btn btn-danger horizontal-bar" data-toggle="modal" data-target="#DeleteModal">
            Remove
        </button>--%>
    </div>

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <div>
                <br />
                <%--<table border="0">
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
                </table>--%>
                <br />
                <dx:ASPxGridView ID="gridPolicy" Theme="Metropolis" KeyFieldName="Policy_ID" runat="server" AutoGenerateCloumns="False" Width="100%">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="Policy_ID" HeaderStyle-HorizontalAlign="Center" VisibleIndex="0" Caption="Policy Id">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="type" HeaderStyle-HorizontalAlign="Center" VisibleIndex="1" Caption="Type">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Name" HeaderStyle-HorizontalAlign="Center" VisibleIndex="2" Caption="Client">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Address" HeaderStyle-HorizontalAlign="Center" VisibleIndex="3" Caption="Address">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Mobile" HeaderStyle-HorizontalAlign="Center" VisibleIndex="4" Caption="Mobile">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Email" HeaderStyle-HorizontalAlign="Center" VisibleIndex="5" Caption="Email">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="RegistrationNo" HeaderStyle-HorizontalAlign="Center" VisibleIndex="6" Caption="Vehicle">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="status" HeaderStyle-HorizontalAlign="Center" VisibleIndex="7" Caption="Status">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowPager" Position="TopAndBottom">
                        <PageSizeItemSettings Items="10, 20, 50" Visible="true" />
                    </SettingsPager>
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Policy Information" />
                    <SettingsBehavior AllowSelectByRowClick="true" />
                </dx:ASPxGridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

    <div class="modal fade" id="PolicyModal">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Employee Details</h4>
                </div>
                <div class="modal-body">

                    <!-- Nav tabs -->
                    <ul class="nav nav-tabs" role="tablist">
                        <li role="presentation" class="active"><a href="#client" aria-controls="client" role="tab" data-toggle="tab">Client</a></li>
                        <li role="presentation"><a href="#vehicle" aria-controls="vehicle" role="tab" data-toggle="tab">Vehicle</a></li>
                        <li role="presentation"><a href="#policy" aria-controls="policy" role="tab" data-toggle="tab">Policy</a></li>
                    </ul>

                    <!-- Tab panes -->
                    <div class="tab-content">
                        <div role="tabpanel" class="tab-pane active" id="client">
                            <br />
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-1 control-label">Salutation</label>
                                    <div class="col-sm-4">
                                        <input runat="server" type="text" class="form-control" id="txtSalutation" />
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-1 control-label">Initials</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtInitials" />
                                    </div>
                                    <label class="col-sm-1 control-label">Firstname</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtFirstname" />
                                    </div>
                                    <label class="col-sm-1 control-label">Lastname</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtLastname" />
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-1 control-label">Address No</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtAddressNo" />
                                    </div>
                                    <label class="col-sm-1 control-label">Street</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtStreet" />
                                    </div>
                                    <label class="col-sm-1 control-label">City</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtCity" />
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-1 control-label">NIC</label>
                                    <div class="col-sm-4">
                                        <input runat="server" type="text" class="form-control" id="txtNic" />
                                    </div>
                                    <label class="col-sm-1 control-label">Email</label>
                                    <div class="col-sm-4">
                                        <input runat="server" type="text" class="form-control" id="txtEmail" />
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-1 control-label">Mobile</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtMobile" />
                                    </div>
                                    <label class="col-sm-1 control-label">Home</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtHome" />
                                    </div>
                                    <label class="col-sm-1 control-label">Office</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtOffice" />
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-1 control-label">Bank</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtBank" />
                                    </div>
                                    <label class="col-sm-1 control-label">Branch</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtBranch" />
                                    </div>
                                    <label class="col-sm-1 control-label">Bank Account</label>
                                    <div class="col-sm-3">
                                        <input runat="server" type="text" class="form-control" id="txtAccountNo" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div role="tabpanel" class="tab-pane" id="vehicle">
                            <br />
                            <div class="form-horizontal">
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <div class="form-horizontal">
                                            <div class="form-group">
                                                <label class="col-sm-1 control-label">Type</label>
                                                <div class="col-sm-3">
                                                    <asp:DropDownList AppendDataBoundItems="true" runat="server" AutoPostBack="true" CssClass="form-control" ID="ddlType" OnSelectedIndexChanged="ddlType_SelectedIndexChanged">
                                                        <asp:ListItem Text="" Value="" Selected="True" />
                                                    </asp:DropDownList>
                                                </div>
                                                <label class="col-sm-2 control-label">Manufacturer</label>
                                                <div class="col-sm-3">
                                                    <asp:DropDownList AppendDataBoundItems="true" runat="server" AutoPostBack="true" CssClass="form-control" ID="ddlmanufacturer" OnSelectedIndexChanged="ddlmanufacturer_SelectedIndexChanged">
                                                        <asp:ListItem Text="" Value="" Selected="True" />
                                                    </asp:DropDownList>
                                                </div>
                                                <label class="col-sm-1 control-label">Model</label>
                                                <div class="col-sm-2">
                                                    <asp:DropDownList AppendDataBoundItems="true" runat="server" AutoPostBack="true" CssClass="form-control" ID="ddlModel" OnSelectedIndexChanged="ddlModel_SelectedIndexChanged">
                                                        <asp:ListItem Text="" Value="" Selected="True" />
                                                    </asp:DropDownList>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="col-sm-12">
                                            <dx:ASPxGridView ID="gridVehicles" KeyFieldName="VehicleID" runat="server" AutoGenerateColumns="False" Width="100%">
                                                <Columns>
                                                    <dx:GridViewDataTextColumn FieldName="VehicleID" VisibleIndex="7" Caption="id" Visible="false">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" FieldName="Model" VisibleIndex="0" Caption="Model">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" FieldName="MakeYear" VisibleIndex="0" Caption="Year">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" FieldName="FuelType" VisibleIndex="1" Caption="Fuel">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" FieldName="EngineCpacity" VisibleIndex="2" Caption="Engine">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" FieldName="seatingCapacity" VisibleIndex="3" Caption="Seating">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" FieldName="CarryingCapacity" VisibleIndex="4" Caption="Carrying">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" FieldName="PresentValue" PropertiesTextEdit-DisplayFormatString="n2" VisibleIndex="5" Caption="Present Value">
                                                    </dx:GridViewDataTextColumn>
                                                    <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" HeaderStyle-Font-Bold="true" FieldName="DutyFreeValue" PropertiesTextEdit-DisplayFormatString="n2" VisibleIndex="6" Caption="Duty Free">
                                                    </dx:GridViewDataTextColumn>
                                                </Columns>
                                                <SettingsPager Mode="ShowPager" />
                                                <Settings ShowTitlePanel="true" />
                                                <SettingsText Title="Sparepart List" />
                                                <SettingsBehavior AllowSelectByRowClick="true" AllowSelectSingleRowOnly="true" />
                                            </dx:ASPxGridView>
                                            <br />
                                        </div>
                                        <div class="form-horizontal">
                                            <div class="form-group">
                                                <label class="col-sm-4 control-label"></label>
                                                <div class="col-sm-4">
                                                    <asp:Button Text="Select the Vehicle" ID="btnSelectVehicle" OnClick="btnSelectVehicle_Click" CssClass="btn btn-success col-sm-10" runat="server" />
                                                </div>
                                                <asp:TextBox CssClass="col-sm-4" runat="server" Visible="false" ID="txtVehicleId" />
                                            </div>
                                        </div>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                            </div>

                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-1 control-label">Reg. No</label>
                                    <div class="col-sm-4">
                                        <input runat="server" type="text" class="form-control" id="txtRegNo" />
                                    </div>
                                    <label class="col-sm-1 control-label">Color</label>
                                    <div class="col-sm-4">
                                        <input runat="server" type="text" class="form-control" id="txtColor" />
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-1 control-label">Engine No</label>
                                    <div class="col-sm-4">
                                        <input runat="server" type="text" class="form-control" id="txtEngineNo" />
                                    </div>
                                    <label class="col-sm-1 control-label">Chassiss No</label>
                                    <div class="col-sm-4">
                                        <input runat="server" type="text" class="form-control" id="txtChassissNo" />
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-1 control-label">Usage</label>
                                    <div class="col-sm-3">
                                        <textarea runat="server" type="text" class="form-control" id="txtUsage" />
                                    </div>
                                    <label class="col-sm-1 control-label">Extra Fittings</label>
                                    <div class="col-sm-3">
                                        <textarea runat="server" type="text" class="form-control" id="txtExtra" />
                                    </div>
                                    <label class="col-sm-1 control-label">Damages</label>
                                    <div class="col-sm-3">
                                        <textarea runat="server" type="text" class="form-control" id="txtDamages" />
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-1 control-label">Absolute Owner</label>
                                    <div class="col-sm-4">
                                        <input runat="server" type="text" class="form-control" id="txtAbsolute" />
                                    </div>
                                    <label class="col-sm-1 control-label">Financial Rights</label>
                                    <div class="col-sm-4">
                                        <input runat="server" type="text" class="form-control" id="txtFinan" />
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div role="tabpanel" class="tab-pane" id="policy">
                            <br />
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">Policy Type</label>
                                    <div class="col-sm-4">
                                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlPolicyType">
                                            <asp:ListItem Text="Full Insurance" Value="Full Insurance" Selected="True" />
                                            <asp:ListItem Text="3rd Party" Value="3rd Party" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">Commence On</label>
                                    <div class="col-sm-4">
                                        <dx:ASPxDateEdit CssClass="form-control" ID="dtCommence" runat="server"></dx:ASPxDateEdit>
                                    </div>
                                    <label class="col-sm-2 control-label">Expire On</label>
                                    <div class="col-sm-4">
                                        <dx:ASPxDateEdit CssClass="form-control" ID="dtExpire" runat="server"></dx:ASPxDateEdit>
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">Natural Disaster</label>
                                    <div class="col-sm-2">
                                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlnatural">
                                            <asp:ListItem Text="" Value="" Selected="True" />
                                            <asp:ListItem Text="Yes" Value="Yes" />
                                            <asp:ListItem Text="No" Value="No" />
                                        </asp:DropDownList>
                                    </div>
                                    <label class="col-sm-2 control-label">Vandalism</label>
                                    <div class="col-sm-2">
                                        <asp:DropDownList runat="server" CssClass="form-control" ID="ddlVandalism">
                                            <asp:ListItem Text="" Value="" Selected="True" />
                                            <asp:ListItem Text="Yes" Value="Yes" />
                                            <asp:ListItem Text="No" Value="No" />
                                        </asp:DropDownList>
                                    </div>
                                    <label class="col-sm-2 control-label">Terrorisom</label>
                                    <div class="col-sm-2">
                                        <asp:DropDownList runat="server" CssClass="col-sm-2 form-control" ID="ddlTerrorism">
                                            <asp:ListItem Text="" Value="" Selected="True" />
                                            <asp:ListItem Text="Yes" Value="Yes" />
                                            <asp:ListItem Text="No" Value="No" />
                                        </asp:DropDownList>
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">Strikes/Riots</label>
                                    <div class="col-sm-2">
                                        <asp:DropDownList runat="server" AutoPostBack="true" CssClass="form-control" ID="ddlStrikes">
                                        <asp:ListItem Text="" Value="" Selected="True" />
                                        <asp:ListItem Text="Yes" Value="Yes" />
                                        <asp:ListItem Text="No" Value="No" />
                                    </asp:DropDownList>
                                    </div>                                 
                                    <label class="col-sm-2 control-label">Air Bag</label>
                                    <div class="col-sm-2">
                                        <asp:DropDownList runat="server" AutoPostBack="true" CssClass="form-control" ID="ddlAirbag">
                                        <asp:ListItem Text="" Value="" Selected="True" />
                                        <asp:ListItem Text="Yes" Value="Yes" />
                                        <asp:ListItem Text="No" Value="No" />
                                    </asp:DropDownList>
                                    </div>                                   
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">Passenger Compensation</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtPasen" />
                                    </div>
                                    <label class="col-sm-2 control-label">Towing Charges</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox runat="server" CssClass="form-control" ID="txtTow" />
                                    </div>
                                </div>
                            </div>
                            <div class="form-horizontal">
                                <div class="form-group">
                                    <label class="col-sm-2 control-label">Driver Compensation</label>
                                    <div class="col-sm-4">
                                        <asp:TextBox runat="server" ID="txtDriverCom" CssClass="form-control" />
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal" id="btnClose" runat="server">Close</button>
                    <button type="button" class="btn btn-primary" runat="server" id="btnSave" onserverclick="btnSave_ServerClick">Save</button>
                    <%--                    <button type="button" class="btn btn-primary" runat="server" id="btnUpdate">Save changes</button>--%>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
</asp:Content>
