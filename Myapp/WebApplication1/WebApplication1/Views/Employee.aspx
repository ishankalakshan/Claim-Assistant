<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="WebApplication1.Views.Employee" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-cogs fa-2x"></i>&nbsp;Employees
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">

    <div class="form-inline">
        <button type="button" class="btn btn-primary horizontal-bar" data-toggle="modal" data-target="#EmployeeModal">
            Add
        </button>
        <button type="button" runat="server" class="btn btn-warning horizontal-bar" name="btnEdit">
            Edit
        </button>
        <button type="button" class="btn btn-danger horizontal-bar">
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
								<label  class="col-sm-2 control-label">Name</label>
								<div class="col-sm-10">
									<input type="text" class="form-control" id="txtName"/>
								</div>
							</div>
							<div class="form-group">
								<label  class="col-sm-2 control-label">Mobile</label>
								<div class="col-sm-10">
									<input type="number" class="form-control" id="txtMobile"/>
								</div>
							</div>
							<div class="form-group">
								<label class="col-sm-2 control-label">Email</label>
								<div class="col-sm-10">
									<input type="email" class="form-control" id="txtEmail"/>
								</div>
							</div>
							<div class="form-group">
								<label  class="col-sm-2 control-label">Branch</label>
								<div class="col-sm-10">
									<input type="text" class="form-control" id="txtBranch"/>
								</div>
							</div>
						</div>
					</div>
					<div class="modal-footer">
						<button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
						<button type="button" class="btn btn-primary">Save changes</button>
					</div>
				</div>
				<!-- /.modal-content -->
			</div>
			<!-- /.modal-dialog -->
		</div>
	</div>

</asp:Content>
