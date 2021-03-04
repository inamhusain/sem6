<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practical12.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
            <asp:ListItem Value="1">img 1</asp:ListItem>
            <asp:ListItem Value="2">img 2</asp:ListItem>
            <asp:ListItem Value="3">img 3</asp:ListItem>
        </asp:DropDownList><br />
        <asp:Image ID="Image1" runat="server" height="362px" Width="312px"/>
    </div>
    </form>
</body>
</html>
