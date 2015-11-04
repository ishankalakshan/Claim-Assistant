<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="TowTruckService.aspx.cs" Inherits="WebApplication1.Views.TowTruckService.TowTruckService" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-cogs fa-2x"></i>&nbsp;Tow Truck Services
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div class="modal fade" id="TowTruckServiceModal">
			<div class="modal-dialog small">
				<div class="modal-content">
					<div class="modal-header">
						<button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
						<h4 class="modal-title">Tow Truck Service Details</h4>
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
								<label for="txtEmail" class="col-sm-2 control-label">Email</label>
								<div class="col-sm-10">
									<input runat="server" type="email" class="form-control" id="txtEmail"/>
								</div>
							</div>
							<div class="form-group">
								<label for="txtLocation" class="col-sm-2 control-label">Location</label>
								<div class="col-sm-10">
									<input runat="server" type="text" class="form-control" id="txtLocation"/>
								</div>
							</div>
							<div class="form-group">
								<label for="txtTp" class="col-sm-2 control-label">Telephone</label>
								<div class="col-sm-10">
									<input runat="server" type="text" class="form-control" id="txtTp"/>
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

    <div class="form-inline">
			<button type="button" class="btn btn-default" data-toggle="modal" data-target="#TowTruckServiceModal">
				Add
			</button>
			<button type="button" runat="server" class="btn btn-default" OnServerClick="btnEdit_Click">
				Edit
			</button>
			<button type="button" class="btn btn-default" data-toggle="modal" data-target="#myModal">
				Remove
			</button>
		</div>

     <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <div>
                    <br />
                    <dx:ASPxTextBox ID="txtLocationSearch" runat="server" OnTextChanged="txtLocationSearch_TextChanged" AutoPostBack="True" Height="30px" NullText="Enter Location to Search" Width="170px">
                    </dx:ASPxTextBox>
                    <br />
                    <dx:ASPxGridView ID="gridTowTrucks" KeyFieldName="id"  runat="server" AutoGenerateColumns="False" Width="100%">
                        <Columns>                          
                            <dx:GridViewDataTextColumn Visible="false" FieldName="id" VisibleIndex="0" Caption="ID">                              
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="name" VisibleIndex="1" Caption="Name">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="location" VisibleIndex="2" Caption="Location" SortOrder="Ascending">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="tp" VisibleIndex="3" Caption="Contact No">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="email" VisibleIndex="4" Caption="Email">
                            </dx:GridViewDataTextColumn>                
                        </Columns>    
                        <SettingsPager Mode="ShowAllRecords" />
                        <Settings ShowTitlePanel="true" />
                        <SettingsText Title="Tow Truck Services" />
                        <SettingsBehavior AllowSelectByRowClick="true" />                  
                    </dx:ASPxGridView>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
</asp:Content>
