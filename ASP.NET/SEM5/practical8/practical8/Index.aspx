<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="practical8.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server" placeholder="Enter No"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server"  placeholder="Enter No"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Process" OnClick="Button1_Click" />
      
    </div>
    </form>
</body>
</html>
