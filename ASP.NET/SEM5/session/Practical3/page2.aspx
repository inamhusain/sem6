<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="Practical3.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
<style>
    .main{
         margin:auto;
         width:50%;
         box-shadow: 0px 0px 8px 1px;
      }
    .main-lbl {
            text-align:center;
            font-family: system-ui;
            letter-spacing: 5px;
            font-weight: 400;
            display:block;
            padding-bottom: 15px;

    }
    .maintlbl{
            text-align:center;
            font-family: system-ui;
            letter-spacing: 5px;
            font-weight: 700;
            display:block;
            margin-top:auto;
            padding-top:15px;
    }
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
        <asp:Label ID="Label4" runat="server" Text="NAME" CssClass="maintlbl"></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="" CssClass="main-lbl"></asp:Label>

        <asp:Label ID="Label5" runat="server" Text="COLLAGE NAME" CssClass="maintlbl"></asp:Label>
        <asp:Label ID="Label2" runat="server" Text="" CssClass="main-lbl"></asp:Label>

        <asp:Label ID="Label6" runat="server" Text="ROLL NO" CssClass="maintlbl"></asp:Label>
        <asp:Label ID="Label3" runat="server" Text="" CssClass="main-lbl"></asp:Label>
    </div>
    </form>
</body>
</html>
