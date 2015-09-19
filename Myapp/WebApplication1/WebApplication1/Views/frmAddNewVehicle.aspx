<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmAddNewVehicle.aspx.cs" Inherits="WebApplication1.Views.frmAddNewVehicle" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="5" ShowItemCaptionColon="False" AlignItemCaptionsInAllGroups="True" Width="500px">
        <Items>
        <dx:LayoutGroup Caption="Vehicle Registration" GroupBoxDecoration="HeadingLine" ColCount="5" SettingsItemCaptions-Location="Left">           
           <Items>
            <dx:EmptyLayoutItem ColSpan="5">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Vehicle Type" ColSpan="5" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                   <dx:ASPxComboBox ID="ddVehicleType" Height="25px" EnableClientSideAPI="true" runat="server" TextField="VehicleTypeName" ValueField="VehicleTypeName">
                     <ValidationSettings>
                       <RequiredField IsRequired="true" ErrorText="Salutation is required" />
                     </ValidationSettings>
                   </dx:ASPxComboBox>
                </dx:LayoutItemNestedControlContainer>
              </LayoutItemNestedControlCollection>
            </dx:LayoutItem>

            <dx:LayoutItem Caption="Manufacturer" ColSpan="5" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                  <dx:ASPxDropDownEdit ID="ddManufacturer" runat="server" Height="25px" EnableClientSideAPI="true">
                     <ValidationSettings>
                       <RequiredField IsRequired="true" ErrorText="Salutation is required" />
                     </ValidationSettings>
                  </dx:ASPxDropDownEdit>
                </dx:LayoutItemNestedControlContainer>
              </LayoutItemNestedControlCollection>
            </dx:LayoutItem>

            <dx:LayoutItem Caption="Model" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                  <dx:ASPxTextBox ID="txtModel" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="First Name is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
              </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Make Year" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                  <dx:ASPxTextBox ID="txtMakeYear" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="First Name is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
              </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="3">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Fuel Type" ColSpan="5" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                  <dx:ASPxDropDownEdit ID="ddFuelType" runat="server" Height="25px" EnableClientSideAPI="true">
                     <ValidationSettings>
                       <RequiredField IsRequired="true" ErrorText="Salutation is required" />
                     </ValidationSettings>
                  </dx:ASPxDropDownEdit>
                </dx:LayoutItemNestedControlContainer>
              </LayoutItemNestedControlCollection>
            </dx:LayoutItem>

             
            <dx:LayoutItem Caption="Engine Capacity" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                  <dx:ASPxTextBox ID="txtEngineCapacity" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="First Name is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
              </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Seating Capacity" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                  <dx:ASPxTextBox ID="txtSeatingCapacity" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="First Name is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
              </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Carrying Capacity" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                  <dx:ASPxTextBox ID="txtCarryingCapacity" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="First Name is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
              </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Present Value" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                  <dx:ASPxTextBox ID="txtPresentValue" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="First Name is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
              </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            <dx:LayoutItem Caption="Duty Free Value" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                  <dx:ASPxTextBox ID="txtDutyFreeValue" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="First Name is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
              </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
          </Items>
        </dx:LayoutGroup>
        </Items>

        <SettingsItemCaptions VerticalAlign="Middle" />
        <Styles>
            <LayoutItem>
                <Paddings PaddingTop="10px" />
            </LayoutItem>
        </Styles>
    </dx:ASPxFormLayout>
</asp:Content>
