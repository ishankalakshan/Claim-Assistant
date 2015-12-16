<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>
<html >
  <head>
    <meta charset="UTF-8">
    <title>Random Login Form</title>
    <link rel="stylesheet" type="text/css" href="css/style-login.css">
    <script src="js/prefixfree.min.js"></script>   
  </head>

  <body>

    <div class="body"></div>
		<div class="grad"></div>
		<div class="header">
			<div>Site<span>Random</span></div>
		</div>
		<br>
		<div class="login">
            <form  runat="server">
                <input runat="server" type="text" placeholder="username" id="txtUsername"><br>
				<input runat="server" type="password" placeholder="password" id="txtPassword"><br>
				<%--<input runat="server" type="button" value="Login" id="btnLogin" onserverclick="btnLogin_Click">--%>
                <asp:Button Text="Login" ID="btnLogin" CssClass="btn-login" OnClick="btnLogin_Click" runat="server" />
            </form>
				
		</div>
    <script src='http://cdnjs.cloudflare.com/ajax/libs/jquery/2.1.3/jquery.min.js'></script>

    
    
    
    
  </body>
</html>
