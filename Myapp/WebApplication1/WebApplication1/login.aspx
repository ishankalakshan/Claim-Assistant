<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="WebApplication1.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <meta charset="utf-8"/>
  <meta name="viewport" content="width=device-width, initial-scale=1"/>
    
    <link href="css/bootstrap.min.css" rel="stylesheet"/>
    <link href="font-awesome/css/font-awesome.css" rel="stylesheet"/>
    <link href="css/sb-admin.css" rel="stylesheet"/>

    <script src="js/jquery-1.10.2.js"></script>
    <script src="js/bootstrap.min.js"></script>
    <script src="js/plugins/metisMenu/jquery.metisMenu.js"></script>
    <script src="js/sb-admin.js"></script>
</head>
<body>
    <div id="wrapper">
        <nav class="navbar navbar-inverse navbar-fixed-top" role="navigation" style="margin-bottom: 0">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle" data-toggle="collapse" data-target=".sidebar-collapse">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>
                <a class="navbar-brand fa fa-2x" href="#">Online Claiming Assistant
                    <!--<img alt="Brand" src="tiles/brand.png"/>-->
                    <i class="fa fa-cog fa-spin"></i>
                </a>
            </div>
       </nav>

        <div class="container">
            <div class="row">
                <div class="col-md-offset-5 col-md-3">
                    <img src="tiles/asd.jpg" width="200px" height="200px" class="img-circle"/>
                </div>
    <div class="row">
        <div class="col-md-offset-5 col-md-3">
            <div class="form-login">
            <h4>Sign in to continue..</h4>
            <form runat="server">
                <asp:TextBox ID="txtUsername" CssClass="form-control input-sm chat-input" placeholder="username" runat="server"></asp:TextBox>           
            <br/>
                <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control input-sm chat-input" placeholder="password" runat="server"></asp:TextBox>            
            <br/>
                <asp:Button ID="btnLogin" CssClass="btn btn-primary btn-md" runat="server" Text="Login" OnClick="btnLogin_Click" />    
            </form>
            </div>                           
        </div>
    </div>
</div>

    </div>
</body>
</html>
