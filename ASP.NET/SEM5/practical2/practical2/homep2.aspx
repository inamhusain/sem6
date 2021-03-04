<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="homep2.aspx.cs" Inherits="practical2.homep2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h1>HELLO</h1>
        <asp:Button ID="Button1" runat="server" Text="Click to print Hello" CssClass="bt1" OnClick="Button1_Click" /><br />
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>