<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="practical3.Images.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#b200ff">
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="go to page 2"  PostBackUrl="page2.aspx" /><br />
        <asp:Label ID="Label1" runat="server" Text="Hello"></asp:Label>
    </div>
    </form>
</body>
</html>
