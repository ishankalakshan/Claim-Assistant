<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Vehicle.aspx.cs" Inherits="WebApplication1.Views.Vehicle" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-automobile"></i>&nbsp;Vehicles
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
        <button type="button" class="btn btn-danger horizontal-bar" runat="server" id="btnRemove" onserverclick="btnRemove_ServerClick">
            Remove
        </button>
    </div>

    <div class="modal fade" id="VehicleModal">
			<div class="modal-dialog">
				<div class="modal-content">
					<div class="modal-header">
						<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
						<h4 class="modal-title">Vehicle Details</h4>
					</div>
					<div class="modal-body">
						<div class="form-horizontal">
							<div class="form-group">
								<label class="col-sm-4 control-label">Type</label>
								<div class="col-sm-8">
									<asp:DropDownList runat="server" CssClass="form-control" ID="ddlType"></asp:DropDownList>
								</div>
							</div>
							<div class="form-group">
								<label for="inputPassword3" class="col-sm-4 control-label">Manufacturer</label>
								<div class="col-sm-8">
									<asp:DropDownList runat="server" CssClass="form-control" ID="ddlmanufacturer"></asp:DropDownList>
								</div>
							</div>
							<div class="form-group">
								<label for="inputEmail3" class="col-sm-4 control-label">Model</label>
								<div class="col-sm-8">
									<input type="text" class="form-control" id="txtModel" runat="server"/>
								</div>
							</div>
							<div class="form-group">
								<label for="inputPassword3" class="col-sm-4 control-label">Year</label>
								<div class="col-sm-8">
									<input type="number" class="form-control" id="txtYear" runat="server"/>
								</div>
							</div>
                            <div class="form-group">
								<label for="inputPassword3" class="col-sm-4 control-label">Fuel</label>
								<div class="col-sm-8">
									<asp:DropDownList runat="server" CssClass="form-control" ID="ddlFuel">
                                        <asp:ListItem Value="Diesel">Diesel</asp:ListItem>
                                        <asp:ListItem Value="Petrol">Petrol</asp:ListItem>
                                        <asp:ListItem Value="Hybrid">Hybrid</asp:ListItem>
                                        <asp:ListItem Value="Eletric">Eletric</asp:ListItem>
                                        <asp:ListItem Value="Hydrogen">Hydrogen</asp:ListItem>
									</asp:DropDownList>
								</div>
							</div>
							<div class="form-group">
								<label for="inputPassword3" class="col-sm-4 control-label">Engine Capacity</label>
								<div class="col-sm-8">
									<input type="text" class="form-control" id="txtEngineCapacity" runat="server"/>
								</div>
							</div>
							<div class="form-group">
								<label for="inputPassword3" class="col-sm-4 control-label">Seating Capacity</label>
								<div class="col-sm-8">
									<input type="text" class="form-control" id="txtSeatCapacity" runat="server"/>
								</div>
							</div>
							<div class="form-group">
								<label for="inputPassword3" class="col-sm-4 control-label">Carrying Capacity</label>
								<div class="col-sm-8">
									<input type="text" class="form-control" id="txtCarryCapacity" runat="server"/>
								</div>
							</div>
							<div class="form-group">
								<label for="inputPassword3" class="col-sm-4 control-label">Present Value</label>
								<div class="col-sm-8">
									<input type="number" class="form-control" id="txtPresentVal" runat="server"/>
								</div>
							</div>
							<div class="form-group">
								<label for="inputPassword3" class="col-sm-4 control-label">Duty Free Value</label>
								<div class="col-sm-8">
									<input type="number" class="form-control" id="txtDutyFreeVal" runat="server"/>
								</div>
							</div>
						</div>
					</div>
					<div class="modal-footer">
						<button type="button" class="btn btn-default" runat="server" data-dismiss="modal" id="btnClose" onserverclick="btnClose_ServerClick">Close</button>
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
                            <dx:ASPxTextBox ID="txtTypeSearch" runat="server" AutoPostBack="True" Height="30px" NullText="Type" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                        <td>&nbsp;&nbsp;</td>
                        <td>
                            <dx:ASPxTextBox ID="txtManufactureSearch" runat="server" AutoPostBack="True" Height="30px" NullText="Manufacturer" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                        <td>&nbsp;&nbsp;</td>
                        <td>
                            <dx:ASPxTextBox ID="txtModelSearch" runat="server" AutoPostBack="True" Height="30px" NullText="Model" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                        <td>&nbsp;&nbsp;</td>
                        <td>
                            <dx:ASPxTextBox ID="txtYearSearch" runat="server" AutoPostBack="True" Height="30px" NullText="Year" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <dx:ASPxGridView ID="gridVehicle" KeyFieldName="VehicleID" runat="server" AutoGenerateColumns="False" Width="100%">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="VehicleID" Visible="false" VisibleIndex="0" Caption="ID">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="VehicleTypeName" VisibleIndex="1" Caption="Type">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="ManufactureName" VisibleIndex="2" Caption="Manufacturer" SortOrder="Ascending">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="Model" VisibleIndex="3" Caption="Model">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="MakeYear" VisibleIndex="4" Caption="Year">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="FuelType" VisibleIndex="5" Caption="Fuel">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="EngineCpacity" VisibleIndex="6" Caption="Engine">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="seatingCapacity" VisibleIndex="7" Caption="Seating">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="CarryingCapacity" VisibleIndex="8" Caption="Carrying">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="PresentValue" PropertiesTextEdit-DisplayFormatString="n2" VisibleIndex="9" Caption="Present Value">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn HeaderStyle-HorizontalAlign="Center" FieldName="DutyFreeValue" PropertiesTextEdit-DisplayFormatString="n2" VisibleIndex="10" Caption="Duty Free">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowAllRecords" />
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Vehicle Information" />
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
