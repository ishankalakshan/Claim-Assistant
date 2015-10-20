<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmNew3wheelStep1.aspx.cs" Inherits="WebApplication1.Views.frmNew3wheelStep1" %>
<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.7.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

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
        <dx:LayoutGroup Caption="Customer Details" GroupBoxDecoration="HeadingLine" ColCount="5" SettingsItemCaptions-Location="Left">           
           <Items>
            <dx:EmptyLayoutItem ColSpan="5">
            </dx:EmptyLayoutItem>

             <dx:LayoutItem Caption="Salutation" ColSpan="5" RequiredMarkDisplayMode="Required">
               <LayoutItemNestedControlCollection>
                 <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                     <dx:ASPxComboBox ID="cmbSalutation" runat="server" Height="25px" EnableClientSideAPI="true">
                      <Items>
                          <dx:ListEditItem Text="Mr" Value="White" />
                          <dx:ListEditItem Text="Mrs" Value="Black" />
                          <dx:ListEditItem Text="Miss" Value="Silver" />
                      </Items>
                      <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True"/>
                    </ValidationSettings>
                  </dx:ASPxComboBox>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>

            <dx:LayoutItem Caption="Initials" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                  <dx:ASPxTextBox ID="txtInitials" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True"/>
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:LayoutItem Caption="Firstname" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                  <dx:ASPxTextBox ID="txtFirstname" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True"/>
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:LayoutItem Caption="Lastname" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                  <dx:ASPxTextBox ID="txtLastname" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True"/>
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Address No" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                  <dx:ASPxTextBox ID="txtAddressNo" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True"/>
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:LayoutItem Caption="Street" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                  <dx:ASPxTextBox ID="txtStreet" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True"/>
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:LayoutItem Caption="City" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                  <dx:ASPxTextBox ID="txtCity" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True"/>
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem> 
             <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="NIC" ColSpan="3" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                  <dx:ASPxTextBox ID="txtNIC" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True"/>
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Office TP">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                  <dx:ASPxTextBox ID="txtOffficeTP" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:LayoutItem Caption="Home TP">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer12" runat="server">
                  <dx:ASPxTextBox ID="txtHomeTP" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:LayoutItem Caption="Mobile No">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer13" runat="server">
                  <dx:ASPxTextBox ID="txtMobileNo" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Email" ColSpan="3">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer16" runat="server">
                  <dx:ASPxTextBox ID="txtEmail" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >                      
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>
           </Items>
        </dx:LayoutGroup>
            <dx:EmptyLayoutItem ColSpan="5">
            </dx:EmptyLayoutItem>
   
            <dx:LayoutItem Caption="" ColSpan="5" HorizontalAlign="Right">
                <LayoutItemNestedControlCollection>
                    <dx:LayoutItemNestedControlContainer runat="server">
                        <dx:ASPxButton ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" Theme="Glass" Width="120px"></dx:ASPxButton>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>
            
        </Items>
        <SettingsItemCaptions VerticalAlign="Middle" />
        <Styles>
            <LayoutItem>
                <Paddings PaddingTop="10px" />
            </LayoutItem>
        </Styles>
    </dx:ASPxFormLayout>
</asp:Content>
