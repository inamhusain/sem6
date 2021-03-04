<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="logintest.main" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>LOGIN</title>
    <link href="main.css" rel="stylesheet" />
  
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
        <h1 class="main-lbllogin">LOGIN</h1>

        <asp:Label ID="label3" runat="server" text="Use this ID: " CssClass="main-lblid"></asp:Label>
        <asp:Label ID="lblid" runat="server" text="inamhusain570@gmail.com" CssClass="main-lblid3"></asp:Label><br />

        <asp:Label ID="label4" runat="server" Text="Use this PASSWORD: " CssClass="main-lblpass"></asp:Label>
        <asp:Label ID="lblpassword" runat="server" Text="1234" CssClass="main-lblpass4"></asp:Label><br />

          <asp:Label ID="Lable1" runat="server" Text="User-Id" CssClass="main-lblid1"></asp:Label>
          <asp:TextBox ID="txtid" runat="server" CssClass="main-id"></asp:TextBox>

          <asp:Label ID="Label2" runat="server" Text="PassWord" CssClass="main-lblpass2"></asp:Label>
          <asp:TextBox ID="txtpass" runat="server" CssClass="main-password"></asp:TextBox>

          <asp:Button ID="btnlogin" runat="server" Text="LOGIN" cssclass="main-btn" OnClick="onclick"/>
        
    </div>
    </form>
</body>
</html>
