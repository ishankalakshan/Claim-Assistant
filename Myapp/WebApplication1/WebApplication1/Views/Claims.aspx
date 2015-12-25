<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Claims.aspx.cs" Inherits="WebApplication1.Views.Claims" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-money"></i>&nbsp;Claims
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager runat="server"></asp:ScriptManager>
    <div class="form-inline">
        <button type="button" class="btn btn-primary horizontal-bar" name="btnReview" id="btnReview" runat="server" onserverclick="btnReview_ServerClick">
            Review
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
                                        <td class="col-sm-2"><label class="control-label">Name</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblName" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Address</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblAddress" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2">
                                            <label class="control-label">NIC</label></td>
                                        <td class="col-sm-10">
                                            <asp:Label Text="" CssClass="control-label" ID="lblNic" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2">
                                            <label class="control-label">Telephone</label></td>
                                        <td class="col-sm-10">
                                            <asp:Label Text="" CssClass="control-label" ID="lblTelephone" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2">
                                            <label class="control-label">Mobile</label></td>
                                        <td class="col-sm-10">
                                            <asp:Label Text="" CssClass="control-label" ID="lblMobile" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2">
                                            <label class="control-label">Email</label></td>
                                        <td class="col-sm-10">
                                            <asp:Label Text="" CssClass="control-label" ID="lblEmail" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2">
                                            <label class="control-label">Bank</label></td>
                                        <td class="col-sm-10">
                                            <asp:Label Text="" CssClass="control-label" ID="lblBank" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2">
                                            <label class="control-label">Branch</label></td>
                                        <td class="col-sm-10">
                                            <asp:Label Text="" CssClass="control-label" ID="lblBranch" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2">
                                            <label class="control-label">Bank Account</label></td>
                                        <td class="col-sm-10">
                                            <asp:Label Text="" CssClass="control-label" ID="lblBankAccount" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="vehicle">
                                <table>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Manufacturer</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblManufacturer" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Model</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblModel" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Year</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblYear" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Present Value</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblPresentValue" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Duty Free Value</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblDutyFreeValue" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Registration No</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblRegistrationNo" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Absolute Owner</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblAbsoluteOwner" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Financial Rights</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblFinancialRights" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Usage</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblUsage" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="policy">
                                <table>
                                     <tr>
                                        <td class="col-sm-2"><label class="control-label">PolicyId</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblPolicyId" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Commence On</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblCommenceOn" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Expire On</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblExpireOn" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Natural Disaster Cover</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblNaturalDisasterCover" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Terrorism Cover</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblTerrorismCover" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Strike/Riot Cover</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblStrikeRiotCover" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Air Bag Cover</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblAirBagCover" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Driver Compensation</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblDriverCompensation" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Passenger Compensation</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblPassengerCompensation" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Towing Charges</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblTowingCharges" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Status</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblStatus" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="claim">
                                <table>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Location</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblLocation" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Reason</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblReason" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Knocked On</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblKnockedOn" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Is Driver Owner</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblIsDriverOwner" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Driver Name</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblDriverName" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Driver NIC</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblDriverNic" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">License</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblLicense" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Debit Outstanding</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblDebitOutstanding" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="thirdparty">
                                <table>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Vehicle No</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblVehicleNo" runat="server" /></td>
                                    </tr>
                                     <tr>
                                        <td class="col-sm-2"><label class="control-label">Owner</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblOwner" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Address</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblThirdpartyAddress" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Notes</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblNotes" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Victim Name</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblVictimName" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Address</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblVictimAddress" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Damages</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblDamages" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Claimant</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblClaimant" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Amount</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblClaimantAmount" runat="server" /></td>
                                    </tr>
                                </table>
                            </div>
                            <div role="tabpanel" class="tab-pane" id="payment">
                                <table>
                                    <tr>
                                        <td><label class="col-sm-2 control-label">Sparelist</label></td>
                                        <td>
                                             <asp:UpdatePanel ID="UpdatePanel1" runat="server">
        <ContentTemplate>
            <div>
                <dx:ASPxGridView ID="gridSpareparts" KeyFieldName="sparepartName" runat="server" AutoGenerateColumns="False" Width="70%">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="sparepartName"  VisibleIndex="0" Caption="Name">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="sparepartQty" VisibleIndex="1" Caption="Quantity">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="sparePartCost" PropertiesTextEdit-DisplayFormatString="n2" VisibleIndex="2" Caption="Unit Cost">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowPager" />
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Sparepart List" />
                    <SettingsBehavior AllowSelectByRowClick="false" />
                </dx:ASPxGridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Garage Costs</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblGarageCosts" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Other Costs</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblOtherCosts" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Deductions</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblDeductions" runat="server" /></td>
                                    </tr>
                                    <tr>
                                        <td class="col-sm-2"><label class="control-label">Amount Payable</label></td>
                                        <td class="col-sm-10"><asp:Label Text="" CssClass="control-label" ID="lblPayable" runat="server" /></td>
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
                <dx:ASPxGridView ID="gridClaims" KeyFieldName="claimId" runat="server" AutoGenerateColumns="False" Width="100%">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="claimId" HeaderStyle-HorizontalAlign="Center" VisibleIndex="0" Caption="Claim Id">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Policy_ID" HeaderStyle-HorizontalAlign="Center" VisibleIndex="1" Caption="Policy">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="CustomerName" HeaderStyle-HorizontalAlign="Center" VisibleIndex="2" Caption="Client">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Mobile" HeaderStyle-HorizontalAlign="Center" VisibleIndex="3" Caption="Mobile">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="createdtime" HeaderStyle-HorizontalAlign="Center" VisibleIndex="4" Caption="Submited On">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="claimStatus" HeaderStyle-HorizontalAlign="Center" VisibleIndex="5" Caption="Status">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowPager" />
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Claims Information" />
                    <SettingsBehavior AllowSelectSingleRowOnly="true" AllowSelectByRowClick="true" />
                </dx:ASPxGridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>

</asp:Content>
