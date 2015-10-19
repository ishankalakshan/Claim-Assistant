<%@ Page Language="C#" AutoEventWireup="true"  CodeFile="Default.aspx.cs" Inherits="_Default" StylesheetTheme="SkinFile" Theme="SkinFile" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<meta http-equiv="Content-Language" content="en-us">
<link href ="style/style1.css" rel="Stylesheet" />
    <title>Welcome to Web Based Claims Processing System (WCPS)</title>
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
					<td height="18" style="padding-top: 0; padding-bottom: 3px; border-left-width:1px; border-right-width:1px; border-top-width:1px; border-bottom-style:solid; border-bottom-width:1px" class ="td1">&nbsp;
					</td>
				</tr>
				<tr>
					<td class="td1" style="background-image: url('images/back1.gif')"><p>&nbsp;</p>
					<p>&nbsp;</p>
					<p>&nbsp;</p>
                        <p>
                            &nbsp;</p>
					<div align="center">
						<table border="1" width="350" cellspacing="1" style="border-collapse: collapse" bordercolor="#666666" id="table2">
							<tr>
								<td class="td2">&nbsp;WCPS : Login</td>
							</tr>
							<tr>
								<td style="padding-left: 10px; padding-top: 10px">
								<table border="0" width="100%" cellpadding="3" id="table3" cellspacing="3">
									<tr>
										<td width="100" class="td1" align="left">Employee No:</td>
										<td align="left">&nbsp;<asp:TextBox ID="TxtLogin" runat="server" ></asp:TextBox></td>
									</tr>
									<tr>
										<td width="100" class="td1" align="left">Password:</td>
										<td align="left">&nbsp;<asp:TextBox ID="TxtPassword" runat="server" TextMode="Password"></asp:TextBox></td>
									</tr>
									<tr>
										<td width="100">&nbsp;</td>
										<td align="left">&nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                            <asp:Button ID="BtnLogin" runat="server"  Text="Login" Width="66px" OnClick="BtnLogin_Click" />&nbsp;</td>
									</tr>
								</table>
								</td>
							</tr>
						</table>
					</div>
					<p>&nbsp;</p>
					<p>&nbsp;</p>
					<p>&nbsp;<p>&nbsp;</td>
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
