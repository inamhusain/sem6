<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practical14.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="lblRollNo" runat="server" Text="RollNo"></asp:Label>
        <asp:TextBox ID="txtRollNo" runat="server"></asp:TextBox><br/>

        <asp:Label ID="lblName" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br/>

        <asp:Label ID="lblCity" runat="server" Text="City"></asp:Label>
        <asp:TextBox ID="txtCity" runat="server"></asp:TextBox><br/>
        
        <asp:Button ID="btnAddNew" runat="server" Text="Add New" OnClick="btnAddNew_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
    </div>
    </form>
</body>
</html>
