<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmNew3wheelStep3.aspx.cs" Inherits="WebApplication1.Views.frmNew3wheelStep3" %>
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
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="5" ShowItemCaptionColon="False" AlignItemCaptionsInAllGroups="True" Width="500px">
        <Items>
        <dx:LayoutGroup Caption="Policy Details" GroupBoxDecoration="HeadingLine" ColCount="5" SettingsItemCaptions-Location="Left">           
           <Items>
            <dx:EmptyLayoutItem ColSpan="5">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Commence On" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                  <dx:ASPxDateEdit ID="dpCommenceOn" runat="server"></dx:ASPxDateEdit>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:LayoutItem Caption="Expire On" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                  <dx:ASPxDateEdit ID="dpExpireOn" runat="server" EnableClientSideAPI="true"></dx:ASPxDateEdit>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:EmptyLayoutItem ColSpan="3">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Natural Disaster Cover" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                  <dx:ASPxCheckBox ID="cbNaturalDisaster" Text="Yes" runat="server" EnableClientSideAPI="true"></dx:ASPxCheckBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:LayoutItem Caption="Vandalism Cover" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                  <dx:ASPxCheckBox ID="cbvandalism" Text="Yes" runat="server" EnableClientSideAPI="true"></dx:ASPxCheckBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:LayoutItem Caption="Terrorism Cover" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                  <dx:ASPxCheckBox ID="cbTerCover" Text="Yes" runat="server" EnableClientSideAPI="true"></dx:ASPxCheckBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Driver Compensation" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                  <dx:ASPxTextBox ID="txtDriverCompensation" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >                    
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:LayoutItem Caption="Passenger Compensation(Rs)" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                  <dx:ASPxTextBox ID="txtPassengerCompensation" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >                    
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="3">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Third Party Damage" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                  <dx:ASPxTextBox ID="txt3rdpartDamage" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >                    
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="4">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Liability on Towing Charges" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                  <dx:ASPxTextBox ID="txtTowing" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >                    
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="4">
            </dx:EmptyLayoutItem>

           </Items>
        </dx:LayoutGroup>
        </Items>
             <SettingsItemCaptions VerticalAlign="Middle" />
      <Styles>
        <LayoutItem>
         <Paddings PaddingTop="15px" />
        </LayoutItem>
      </Styles>
    </dx:ASPxFormLayout>
</asp:Content>
