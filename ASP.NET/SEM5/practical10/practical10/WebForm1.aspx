<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practical10.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>
        <asp:TextBox ID="TextBoxAdd" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="ADD" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
