<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="practical4.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" method="get">
    <div>
        <asp:Label ID="lbl1" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="txt1" runat="server"></asp:TextBox>
<br />

        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="txt2" runat="server" TextMode="Password"></asp:TextBox>
<br />

        <asp:Button ID="Button1" runat="server" Text="Button" Postbackurl="~/page2.aspx"/>
    </div>
    </form>
</body>
</html>
