<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmNewInsuranceStep1.aspx.cs" Inherits="WebApplication1.Views.frmNewInsuranceStep1" %>
<%@ Register Assembly="DevExpress.Web.v14.2, Version=14.2.4.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="cpPageContaintName" runat="server">
    <i class="fa fa-user fa-2x"></i>&nbsp;New Insurance
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cpFprmContaintName" runat="server">
    <i class="fa fa-bars"></i>&nbsp;Menu
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cpForm" runat="server">
    <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
<dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="5" ShowItemCaptionColon="False" AlignItemCaptionsInAllGroups="True" Width="500px">
        <Items>
        <dx:LayoutGroup Caption="Personal Details" ColCount="5" SettingsItemCaptions-Location="Left">           
           <Items>
             <dx:LayoutItem Caption="Salutation" ColSpan="5" RequiredMarkDisplayMode="Required">
               <LayoutItemNestedControlCollection>
                 <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                   <dx:ASPxDropDownEdit ID="ddSalutation" runat="server" Height="25px" EnableClientSideAPI="true">
                     <ValidationSettings>
                       <RequiredField IsRequired="true" ErrorText="Salutation is required" />
                         </ValidationSettings>
                        </dx:ASPxDropDownEdit>
                    </dx:LayoutItemNestedControlContainer>
                </LayoutItemNestedControlCollection>
            </dx:LayoutItem>

            <dx:LayoutItem Caption="Initials" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                  <dx:ASPxTextBox ID="txtInitials" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="Initials is required" />
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
                      <RequiredField IsRequired="True" ErrorText="First Name is required" />
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
                      <RequiredField IsRequired="True" ErrorText="Initials is required" />
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
                      <RequiredField IsRequired="True" ErrorText="Initials is required" />
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
                      <RequiredField IsRequired="True" ErrorText="Initials is required" />
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
                      <RequiredField IsRequired="True" ErrorText="Initials is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem> 
             <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>
                
             <dx:LayoutItem Caption="NIC" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                  <dx:ASPxTextBox ID="txtNIC" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="Initials is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:LayoutItem Caption="Age" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
                  <dx:ASPxTextBox ID="txtAge" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="Initials is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="3">
            </dx:EmptyLayoutItem>

             <dx:LayoutItem Caption="Occupation" ColSpan="3" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                  <dx:ASPxTextBox ID="txtOccupation" runat="server" Height="25px"
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="Initials is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="VAT Registration No" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer14" runat="server">
                  <dx:ASPxTextBox ID="txtVATNo" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" ErrorText="Initials is required" />
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:LayoutItem Caption="Business Registration No" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer15" runat="server">
                  <dx:ASPxTextBox ID="txtBusinessNo" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
             <dx:EmptyLayoutItem ColSpan="3">
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
                             
            <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>                             
        </Items>
        <SettingsItemCaptions VerticalAlign="Middle" />
        <Styles>
            <LayoutItem>
                <Paddings PaddingTop="10px" />
            </LayoutItem>
        </Styles>
    </dx:ASPxFormLayout>
</asp:Content>
