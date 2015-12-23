<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Claims.aspx.cs" Inherits="WebApplication1.Views.Claims" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <div class="form-inline">
        <button type="button" class="btn btn-primary horizontal-bar" data-toggle="modal" data-target="#Modal">
            Add
        </button>
    </div>

    <div class="modal fade" id="Modal">
        <div class="modal-dialog modal-lg">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Employee Details</h4>
                </div>
                <div class="modal-body">

                    <div>
                        <!-- Nav tabs -->
                        <ul class="nav nav-tabs" role="tablist">
                            <li role="presentation" class="active"><a href="#client" aria-controls="client" role="tab" data-toggle="tab">Client</a></li>
                            <li role="presentation"><a href="#vehicle" aria-controls="vehicle" role="tab" data-toggle="tab">Vehicle</a></li>
                            <li role="presentation"><a href="#policy" aria-controls="policy" role="tab" data-toggle="tab">Policy</a></li>
                            <li role="presentation"><a href="#claim" aria-controls="claim" role="tab" data-toggle="tab">Claim</a></li>
                            <li role="presentation"><a href="#thirdparty" aria-controls="thirdparty" role="tab" data-toggle="tab">Third party</a></li>
                            <li role="presentation"><a href="#payment" aria-controls="payment" role="tab" data-toggle="tab">Payment</a></li>
                        </ul>

                        <!-- Tab panes -->
                        <div class="tab-content">
                            <div role="tabpanel" class="tab-pane active" id="client">
                                <table>
                                    <tr>
                                        <td>
                                            <label class="col-sm-2 control-label">Name</label></td>
                                        <td>
                                            <asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblName" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label class="col-sm-2 control-label">Address</label></td>
                                        <td>
                                            <asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblAddress" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label class="col-sm-2 control-label">NIC</label></td>
                                        <td>
                                            <asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblNic" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label class="col-sm-2 control-label">Telephone</label></td>
                                        <td>
                                            <asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblTelephone" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label class="col-sm-2 control-label">Mobile</label></td>
                                        <td>
                                            <asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblMobile" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label class="col-sm-2 control-label">Email</label></td>
                                        <td>
                                            <asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblEmail" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label class="col-sm-2 control-label">Bank</label></td>
                                        <td>
                                            <asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblBank" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label class="col-sm-2 control-label">Branch</label></td>
                                        <td>
                                            <asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblBranch" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td>
                                            <label class="col-sm-2 control-label">Bank Account</label></td>
                                        <td>
                                            <asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblBankAccount" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="vehicle">
                                <table>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Manufacturer</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblManufacturer" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Model</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblModel" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Year</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblYear" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Present Value</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblPresentValue" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Duty Free Value</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblDutyFreeValue" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Registration No</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblRegistrationNo" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Absolute Owner</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblAbsoluteOwner" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Financial Rights</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblFinancialRights" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Usage</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblUsage" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="policy">
                                <table>
                                     <tr>
                                        <td><label class="col-sm-2 control-label">PolicyId</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblPolicyId" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Commence On</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblCommenceOn" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Expire On</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblExpireOn" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Natural Disaster Cover</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblNaturalDisasterCover" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Terrorism Cover</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblTerrorismCover" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Strike/Riot Cover</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblStrikeRiotCover" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Air Bag Cover</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblAirBagCover" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Driver Compensation</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblDriverCompensation" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Passenger Compensation</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblPassengerCompensation" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Towing Charges</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblTowingCharges" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Status</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblStatus" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="claim">
                                <table>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Location</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label1" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Reason</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label2" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Knocked On</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label3" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Is Driver Owner</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label4" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Driver Name</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label5" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Driver NIC</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label6" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Licence</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label7" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Debit Outstanding</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label9" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="thirdparty">
                                <table>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Vehicle No</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label10" runat="server" /></td>
                                    </tr>
                                     <tr>
                                        <td><label class="col-sm-2 control-label">Owner</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label11" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Address</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label12" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Notes</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label13" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Victim Name</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label14" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Address</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label15" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Damages</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label16" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Claimant</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label17" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Amount</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label18" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="payment">
                                <table>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Sparelist</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label19" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Garage Costs</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label20" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Other Costs</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label21" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Deductions</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label22" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Amount Payable</label></td>
                                        <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="Label23" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                        </div>

                    </div>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-default" data-dismiss="modal" id="btnClose" runat="server">Close</button>
                    <button type="button" class="btn btn-primary" runat="server" id="btnSave">Save</button>
                    <button type="button" class="btn btn-primary" runat="server" id="btnUpdate">Save changes</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>

</asp:Content>
