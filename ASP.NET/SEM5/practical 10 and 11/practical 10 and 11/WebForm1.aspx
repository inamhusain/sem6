<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practical_10_and_11.WebForm1" %>

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
        <asp:TextBox ID="TextBox" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click_add" />
        <asp:Button ID="Button2" runat="server" Text="Remove" OnClick="Button1_Click_remove" />
       
        
        
        <%-- <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>gujart</asp:ListItem>
            <asp:ListItem>rajasthan</asp:ListItem>
        </asp:DropDownList>
        <asp:Button ID="Button1" runat="server" Text="Add" OnClick="Button1_Click" />

        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>--%>
    </div>
    </form>
</body>
</html>
