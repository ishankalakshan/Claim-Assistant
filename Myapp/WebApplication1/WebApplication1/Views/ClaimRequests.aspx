<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ClaimRequests.aspx.cs" Inherits="WebApplication1.Views.ClaimRequests" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <script src="http://maps.google.com/maps?file=api&amp;v=2&amp;sensor=false" type="text/javascript"></script>
    <script src="//maps.googleapis.com/maps/api/js?sensor=false"
        type="text/javascript"></script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
     <i class="fa fa-user"></i>&nbsp;Employees
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
     <asp:ScriptManager runat="server"></asp:ScriptManager>

    <div class="form-inline">
        <button type="button" runat="server" class="btn btn-primary horizontal-bar" id="btnRespond" onserverclick="btnRespond_ServerClick">
            Respond
        </button>
    </div>

    <div class="modal fade" id="DetailsModal">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
                    <h4 class="modal-title">Claim Request</h4>
                </div>
                <div class="modal-body">
                    <table>
                        <tr>
                            <td colspan="2"><asp:Label Text="" CssClass="col-sm-10 control-label" ID="id" Visible="false" runat="server" /></td>                        
                        </tr>
                        <tr>
                            <td><label class="col-sm-2 control-label">Policy Id</label></td>
                            <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblPolicyId" runat="server" /></td>                        
                        </tr>
                        <tr>
                            <td><label class="col-sm-2 control-label">Client</label></td>
                            <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblClient" runat="server" /></td>                         
                        </tr>
                        <tr>
                            <td><label class="col-sm-2 control-label">Mobile</label></td>
                            <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblMobile" runat="server" /></td>               
                        </tr>
                        <tr>
                            <td><label class="col-sm-2 control-label">Status</label></td>                           
                            <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblStatus" runat="server" /></td>
                        </tr>
                        <tr>
                            <td><label class="col-sm-2 control-label">Submited Time</label></td>                        
                            <td><asp:Label Text="" CssClass="col-sm-10 control-label" ID="lblSubmitTime" runat="server" /></td>
                        </tr>
                        <tr>
                            <td colspan="2">
                                 <div>
                                   <asp:Panel ID="Panel1" runat="server">
                                       <%--Place holder to fill with javascript by server side code--%>
                                       <asp:Literal ID="js" runat="server"></asp:Literal>
                                       <%--Place for google to show your MAP--%>
                                       <div id="map_canvas" style="width: 100%; height: 400px; 
		                            margin-bottom: 2px;">
                                       </div>
                                   </asp:Panel> 
                                </div>
                            </td>                        
                        </tr>
                       
                    </table>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-primary btn-sm" data-dismiss="modal">No</button>
                    <button type="button" runat="server" class="btn btn-success btn-sm" data-dismiss="modal" id="btnResponded" onserverclick="btnResponded_ServerClick"> Mark as Responded</button>
                </div>
            </div>
        </div>
    </div>

    <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <div>
                <br />
                <table border="0">
                    <tr>
                        <td>
                            <dx:ASPxTextBox ID="txtStatusSearch" runat="server" AutoPostBack="True" Height="30px" NullText="Enter status Search" Width="170px">
                            </dx:ASPxTextBox>
                        </td>
                    </tr>
                </table>
                <br />
                <dx:ASPxGridView ID="gridClaimRequests" KeyFieldName="id" runat="server" AutoGenerateColumns="False" Width="100%" onhtml OnHtmlDataCellPrepared="gridClaimRequests_HtmlDataCellPrepared">
                    <Columns>
                        <dx:GridViewDataTextColumn FieldName="id" Visible="false" VisibleIndex="0" Caption="ID">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Policy_ID" VisibleIndex="1" Caption="PolicyId">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Client" VisibleIndex="2" Caption="Client">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="Mobile" VisibleIndex="3" Caption="Telephone">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="status" VisibleIndex="4" Caption="Status">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="submittime" VisibleIndex="5" Caption="Submit">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="respondtime" VisibleIndex="6" Caption="Respond">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="latitude" Visible="false" VisibleIndex="7" Caption="latitude">
                        </dx:GridViewDataTextColumn>
                        <dx:GridViewDataTextColumn FieldName="longitude" Visible="false" VisibleIndex="8" Caption="longitude">
                        </dx:GridViewDataTextColumn>
                    </Columns>
                    <SettingsPager Mode="ShowPager" />
                    <Settings ShowTitlePanel="true" />
                    <SettingsText Title="Claim Requests" />
                    <SettingsBehavior AllowSelectByRowClick="true" AllowSelectSingleRowOnly="true" />
                </dx:ASPxGridView>
            </div>
        </ContentTemplate>
    </asp:UpdatePanel>



</asp:Content>
