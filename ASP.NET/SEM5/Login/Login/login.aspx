<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Login.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <link href="css/login.css" rel="stylesheet" />

        <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    
 
</head>
<body>
    <form id="form1" runat="server">
    <div class="outer" runat="server">
        <div class="main" runat="server">
            <h1 class="titleh1" runat="server">LOGIN</h1>

            <asp:Label ID="lblusername" runat="server" Text="USERNAME" CssClass="userh2"></asp:Label>
            <asp:TextBox ID="txtusername" runat="server" cssclass="form-control"></asp:TextBox>

            <asp:Label ID="lblpass" runat="server" Text="PASSWORD"  CssClass="userh2"></asp:Label>
            <asp:TextBox ID="txtpass" runat="server" type="password" cssclass="form-control"></asp:TextBox>

            <input  class="form-submit-btn" id="Button1" type="button" value="button />        
        </div>    
    </div>
    </form>
</body>
    
</html>
