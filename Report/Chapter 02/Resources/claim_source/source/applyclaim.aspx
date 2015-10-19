<%@ Page Language="C#" AutoEventWireup="true" CodeFile="applyclaim.aspx.cs" Inherits="applyclaim" StylesheetTheme="SkinFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
<meta http-equiv="Content-Language" content="en-us">
<link href ="style/style1.css" rel="Stylesheet" />
    <title>WCPS :: Apply Claim</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
         
			<div align="center">
         	<table width ="1000" border="1" style="border-collapse: collapse" bordercolor="#000000" cellspacing="1" cellpadding="0">
         	<tr>
         	<td>
         	

			<table border="0" width="1000" cellspacing="0" id="table1" cellpadding="0">
				<tr>
					<td>
					<img border="0" src="images/top1.gif" width="1000" height="67"></td>
				</tr>
				<tr>
					<td height="18" style="padding-top: 0; padding-bottom: 3px; border-left-width:1px; border-right-width:1px; border-top-width:1px; border-bottom-style:solid; border-bottom-width:1px" class ="td1" align="left">
					&nbsp; Welcome back, <span id="sp_name" runat="server"></span> &nbsp; &nbsp; 
					<a href="mypage.aspx">HOME</a>&nbsp; |&nbsp; 
					<span id="sp_link" runat ="server"></span>

                        
                        
					<a href="changepassword.aspx">CHANGE PASSWORD</a>&nbsp; |&nbsp; 
					<a href="logout.aspx">LOGOUT</a></td>
				</tr>
				<tr>
					<td class="td1" style="background-image: url('images/back1.gif')">
					<p>&nbsp;</p>
                        <p>
                            &nbsp;</p>
					<div align="center">
						<table border="1" width="573" cellspacing="1" style="border-collapse: collapse" bordercolor="#999999" id="table2">
							<tr>
								<td class="td2">
								<p align="left">&nbsp; WCPS : Enter New Claim 
								Details</td>
							</tr>
							<tr>
								<td>
								<table border="0" width="97%" id="table3" cellpadding="2">
                                    <tr>
                                        <td align="left" class="td1" valign="top" width="54">
                                        </td>
                                        <td align="left" class="td1" style="width: 112px" valign="top">
                                        </td>
                                        <td align="left" class="td1" valign="top">
                                        </td>
                                    </tr>
									<tr>
										<td width="54" class="td1" align="left" valign="top">&nbsp;</td>
										<td class="td1" align="left" valign="top" style="width: 112px">&nbsp;Claim Type:</td>
										<td class="td1" align="left" valign="top">&nbsp;<asp:DropDownList ID="DdlType" runat="server" BackColor="WhiteSmoke"
                                                Font-Names="arial" Font-Size="8pt" Width="131px">
                                            </asp:DropDownList>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2"
                                            runat="server" ControlToValidate="DdlType" ErrorMessage="* Select Type" InitialValue="---Select---"></asp:RequiredFieldValidator></td>
									</tr>
									<tr>
										<td width="54" class="td1" align="left" valign="top">&nbsp;</td>
										<td class="td1" align="left" valign="top" style="width: 112px">&nbsp;Claim Amount:</td>
										<td class="td1" align="left" valign="top">&nbsp;<asp:TextBox ID="TxtAmount" runat="server"></asp:TextBox>&nbsp;
                                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="TxtAmount"
                                                Display="Dynamic" ErrorMessage="CompareValidator" Operator="DataTypeCheck" Type="Double">* Numeric only</asp:CompareValidator>
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtAmount"
                                                ErrorMessage="* Enter Amount"></asp:RequiredFieldValidator></td>
									</tr>
									<tr>
										<td width="54" class="td1" align="left" valign="top">&nbsp;</td>
										<td class="td1" align="left" valign="top" style="width: 112px">&nbsp;Remarks:</td>
										<td class="td1" align="left" valign="top">&nbsp;<asp:TextBox ID="TxtDescription" runat="server" MaxLength="250" TextMode="MultiLine"
                                                Width="301px"></asp:TextBox>&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3"
                                                    runat="server" ControlToValidate="TxtDescription" ErrorMessage="* Enter Remarks"></asp:RequiredFieldValidator></td>
									</tr>
									<tr>
										<td width="54" class="td1" align="left" valign="top">&nbsp;</td>
										<td class="td1" align="left" valign="top" style="width: 112px">&nbsp;</td>
										<td class="td1" align="left" valign="top">&nbsp;</td>
									</tr>
									<tr>
										<td width="54" class="td1" align="left" valign="top">&nbsp;</td>
										<td class="td1" align="left" valign="top" style="width: 112px">&nbsp;</td>
										<td class="td1" align="left" valign="top">&nbsp;<asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />&nbsp;
                                            <asp:Button ID="BtnBack" runat="server" Text="Back" OnClick="BtnBack_Click" /></td>
									</tr>
									<tr>
										<td width="54" class="td1" align="left" valign="top">&nbsp;</td>
										<td class="td1" align="left" valign="top" style="width: 112px">&nbsp;</td>
										<td class="td1" align="left" valign="top">&nbsp;</td>
									</tr>
								</table>
								</td>
							</tr>
						</table>
					</div>
					<p>&nbsp;</p>
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowMessageBox="True"
                            ShowSummary="False" />
					<p>
                        &nbsp;<p>&nbsp;</td>
				</tr>
				<tr>
					<td height="20" style="border-left-width: 1px; border-right-width: 1px; border-top-style: solid; border-top-width: 1px; border-bottom-width: 1px" class="td1">
					<p align="center"><font face="Times New Roman">©</font> WCPS 
					- Web Based Claims System, 2009</td>
				</tr>
			</table>
		          	</td>
         	</tr>
         	</table>
         
			</div>
		 
	</div>
    </form>
</body>
</html>
