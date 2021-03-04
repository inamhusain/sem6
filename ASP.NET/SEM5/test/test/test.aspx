<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="test.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label ><br /><br />

        <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Value="">select name</asp:ListItem>
            <asp:ListItem Value="1">Inamhusain</asp:ListItem>
            <asp:ListItem Value="2">Kamiyabali</asp:ListItem>
            <asp:ListItem Value="3">Faizmohammad</asp:ListItem>
            <asp:ListItem Value="4">Bakarali</asp:ListItem>
            <asp:ListItem Value="5">Fateali</asp:ListItem>
        </asp:DropDownList><br /><br />
        
        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
    </div>
    </form>
</body>
</html>
