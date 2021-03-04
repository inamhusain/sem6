<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="practical17.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <center>
        <h1>Employee Data</h1><br />
        
        <asp:TextBox ID="txtEmpNo" runat="server" placeholder="Employee No" Height="34px"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtEmpName" runat="server" placeholder="Employee Name"></asp:TextBox><br /><br />
        <asp:TextBox ID="txtAddress" runat="server" placeholder="Address"></asp:TextBox><br /><br />
        <asp:TextBox ID="TxtEmpSalary" runat="server" placeholder="Employee Salary"></asp:TextBox><br /><br />


        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click"></asp:Button>
        &nbsp;
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click"></asp:Button>
        &nbsp;
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click"></asp:Button>
        &nbsp;
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"></asp:Button>
        &nbsp;
        <asp:Button ID="btnDisplay" runat="server" Text="Display" OnClick="btnDisplay_Click"></asp:Button>

    </center>
    </div>
    </form>
</body>
</html>
