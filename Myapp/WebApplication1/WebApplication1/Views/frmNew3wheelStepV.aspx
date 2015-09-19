<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmNew3wheelStepV.aspx.cs" Inherits="WebApplication1.Views.frmNew3wheelStepV" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-plus-circle fa-2x"></i>&nbsp;New Insurance
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
    <i class="fa fa-train"></i>&nbsp;New 3 Wheel Insurance
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="3" ShowItemCaptionColon="False" AlignItemCaptionsInAllGroups="True" Width="500px">
      <Items>
        <dx:LayoutGroup Caption="Select Vehicle" Width="100%" GroupBoxDecoration="HeadingLine" ColCount="3" SettingsItemCaptions-Location="Left">           
          <Items>
            <dx:LayoutItem Caption="" ColSpan="3" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                  <asp:UpdatePanel ID="UpdatePanel2" runat="server">
            <ContentTemplate>
                <div>
                    <br />
                    <dx:ASPxTextBox ID="txtModel" runat="server" AutoPostBack="True" Height="30px" NullText="Enter Location to Search" Width="170px">
                    </dx:ASPxTextBox>
                    <br />
                    <dx:ASPxGridView ID="gridvehicles" KeyFieldName="VehicleID"  runat="server" AutoGenerateColumns="False" Width="100%">
                        <Columns>
                            <dx:GridViewDataTextColumn FieldName="VehicleID" VisibleIndex="9" Visible="false">                              
                            </dx:GridViewDataTextColumn>                           
                            <dx:GridViewDataTextColumn FieldName="VehicleTypeID" VisibleIndex="0" Caption="Type">                              
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="ManufactureName" VisibleIndex="1" Caption="Manufacturer">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="Model" VisibleIndex="2" Caption="Model" SortOrder="Ascending">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="MakeYear" VisibleIndex="3" Caption="Year">
                            </dx:GridViewDataTextColumn> 
                            <dx:GridViewDataTextColumn FieldName="EngineCpacity" VisibleIndex="4" Caption="Engine Capacity">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="seatingCapacity" VisibleIndex="5" Caption="Seating Capacity">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="CarryingCapacity" VisibleIndex="6" Caption="Carrying Capacity">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="PresentValue" VisibleIndex="7" Caption="Present Value">
                            </dx:GridViewDataTextColumn>
                            <dx:GridViewDataTextColumn FieldName="DutyFreeValue" VisibleIndex="8" Caption="Duty Free Value">
                            </dx:GridViewDataTextColumn>              
                        </Columns>    
                        <SettingsEditing EditFormColumnCount="3" Mode="PopupEditForm" />
                        <SettingsPopup>
                          <EditForm Width="800"/>
                        </SettingsPopup>
                        <SettingsPager Mode="ShowAllRecords" />
                        <Settings ShowTitlePanel="true" />
                        <SettingsText Title="Garages Information" />
                        <SettingsBehavior AllowSelectByRowClick="true" />                  
                    </dx:ASPxGridView>
                </div>
            </ContentTemplate>
        </asp:UpdatePanel>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
              <dx:LayoutItem Caption="" ColSpan="3" HorizontalAlign="Right">
           <LayoutItemNestedControlCollection>
              <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
               <dx:ASPxButton ID="btnNext" runat="server" Text="Next" OnClick="btnNext_Click"  Theme="Glass" Width="120px"></dx:ASPxButton>
             </dx:LayoutItemNestedControlContainer>
            </LayoutItemNestedControlCollection>
        </dx:LayoutItem>
         </Items>
        </dx:LayoutGroup>
    </Items>
    </dx:ASPxFormLayout>
</asp:Content>
