 <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgotpass.aspx.cs" Inherits="logintest.forgotpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="main.css" rel="stylesheet" />
    <style>
    .main-lblps{
    margin-left: 41%;
    }
    .main-btn1{
        margin-left: 41%;
        margin-top: 3%;
        margin-bottom: 3%;
    }
 
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
        <h1 class="main-lbllogin">Create Account</h1>

        <asp:Label ID="label1" runat="server" Text="USER_ID" CssClass="main-lblps"></asp:Label>
        <asp:TextBox ID="txtu_id" runat="server" CssClass="main-id" ></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="SET Password"  CssClass="main-lblps"></asp:Label>
        <asp:TextBox ID="txtU_password" runat="server" CssClass="main-id"></asp:TextBox>

           <asp:Button ID="btnchngpass" runat="server" Text="SUBMIT" cssclass="main-btn1" OnClick="btnchngpass_Click"/>
    
    </div>
    </form>
</body>
</html>
