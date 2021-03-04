<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practical_13.WebForm1" theme="Theme1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Button ID="Button1" SkinID="Btn" CssClass="Btn" runat="server" Text="Web form 1" PostBackUrl="~/WebForm1.aspx"/>
        <asp:Button ID="Button2" SkinID="Btn" CssClass="Btn" runat="server" Text="Web form 2"  PostBackUrl="~/WebForm2.aspx"/>
        <h1>Web Form 1</h1>
    </div>
    </form>
</body>
</html>
