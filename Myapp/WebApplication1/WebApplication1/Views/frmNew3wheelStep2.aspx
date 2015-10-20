<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="frmNew3wheelStep2.aspx.cs" Inherits="WebApplication1.Views.frmNew3wheelStep2" %>
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
    <dx:ASPxFormLayout ID="ASPxFormLayout1" runat="server" ColCount="3" ShowItemCaptionColon="False" AlignItemCaptionsInAllGroups="True" Width="500px">
      <Items>
         

        <dx:LayoutGroup Caption="Vehicle Details" Width="100%" GroupBoxDecoration="HeadingLine" ColCount="3" SettingsItemCaptions-Location="Left">           
          <Items>
            <dx:EmptyLayoutItem ColSpan="3">
            </dx:EmptyLayoutItem>
       
              <dx:LayoutItem Caption="" ColSpan="3" Visible="false" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer10" runat="server">
                  <dx:ASPxTextBox ID="txtVehicleID" Visible="false" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True"/>
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>

            <dx:LayoutItem Caption="Vehicle Selected" ColSpan="3" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer11" runat="server">
                  <dx:ASPxTextBox ID="txtSelected" Enabled="false" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True"/>
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>


             <dx:LayoutItem Caption="Registration No" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer2" runat="server">
                  <dx:ASPxTextBox ID="txtRegistration" runat="server" Height="25px" 
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

            <dx:LayoutItem Caption="Color" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer1" runat="server">
                  <dx:ASPxComboBox ID="cmbColor" runat="server" Height="25px" EnableClientSideAPI="true">
                      <Items>
                          <dx:ListEditItem Text="White" Value="White" />
                          <dx:ListEditItem Text="Black" Value="Black" />
                          <dx:ListEditItem Text="Silver" Value="Silver" />
                          <dx:ListEditItem Text="Red" Value="Red" />
                          <dx:ListEditItem Text="Blue" Value="Blue" />
                      </Items>
                      <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >
                      <RequiredField IsRequired="True" />
                    </ValidationSettings>
                  </dx:ASPxComboBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Engine Number" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer16" runat="server">
                  <dx:ASPxTextBox ID="txtEngineNumber" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >                     
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:LayoutItem Caption="Chassis Number" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer3" runat="server">
                  <dx:ASPxTextBox ID="txtChassisNumber" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >                    
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="1">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Current Damages">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer4" runat="server">
                    <dx:ASPxMemo ID="txtCurrentDamage" runat="server" Height="50px" Width="170px" EnableClientSideAPI="true">
                    </dx:ASPxMemo>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="2">
           </dx:EmptyLayoutItem>
            
           <dx:LayoutItem Caption="Absolute Owner">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer5" runat="server">
                    <dx:ASPxRadioButtonList ID="rdbAbsoluteOwner" runat="server">
                        <Items>
                            <dx:ListEditItem Text="Bank Loan" Value="BankLoan" />
                            <dx:ListEditItem Text="Lease" Value="Lease" />
                        </Items>
                    </dx:ASPxRadioButtonList>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
           <dx:EmptyLayoutItem ColSpan="2">
           </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Financial Rights" RequiredMarkDisplayMode="Required">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer6" runat="server">
                  <dx:ASPxTextBox ID="txtFinancialRights" runat="server" Height="25px" 
                            EnableClientSideAPI="True">
                    <ValidationSettings ValidationGroup="Gr1" ErrorTextPosition="Bottom" SetFocusOnError="True" >                    
                    </ValidationSettings>
                  </dx:ASPxTextBox>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="2">
            </dx:EmptyLayoutItem>

            <dx:LayoutItem Caption="Extra Fittings">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer7" runat="server">
                    <dx:ASPxMemo ID="txtExtraFittings" runat="server" Height="50px" Width="170px" EnableClientSideAPI="true">
                    </dx:ASPxMemo>
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
            <dx:EmptyLayoutItem ColSpan="2">
           </dx:EmptyLayoutItem>

        <dx:LayoutItem Caption="Usage">
              <LayoutItemNestedControlCollection>
                <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer8" runat="server">
                    <dx:ASPxCheckBoxList ID="cbUsage" runat="server" >
                        <Items>
                            <dx:ListEditItem Text="Private" Value="Private" />
                            <dx:ListEditItem Text="Hire" Value="Hire" />
                            <dx:ListEditItem Text="Rent" Value="Rent" />
                        </Items>
                    </dx:ASPxCheckBoxList>                    
                </dx:LayoutItemNestedControlContainer>
               </LayoutItemNestedControlCollection>
             </dx:LayoutItem>
           <dx:EmptyLayoutItem ColSpan="2">
           </dx:EmptyLayoutItem>

        <dx:LayoutItem Caption="" ColSpan="3" HorizontalAlign="Right">
           <LayoutItemNestedControlCollection>
              <dx:LayoutItemNestedControlContainer ID="LayoutItemNestedControlContainer9" runat="server">
               <dx:ASPxButton ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next"  Theme="Glass" Width="120px"></dx:ASPxButton>
             </dx:LayoutItemNestedControlContainer>
            </LayoutItemNestedControlCollection>
        </dx:LayoutItem>
         </Items>

        <SettingsItemCaptions Location="Left"></SettingsItemCaptions>
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
