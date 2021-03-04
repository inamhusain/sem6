<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="practical3.Images.page2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:#0094ff">
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" runat="server" Text="go to page 1" PostBackUrl="~/Images/page1.aspx" /><br />
        <asp:Label ID="Label1" runat="server" Text="How r u?"></asp:Label>
    </div>
    </form>
</body>
</html>
