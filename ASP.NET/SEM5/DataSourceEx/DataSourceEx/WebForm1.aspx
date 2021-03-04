<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="DataSourceEx.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <%--<asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>--%>
        <%--<asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient" ConnectionString="Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\DataSourceEx\DataSourceEx\App_Data\Database1.mdf;Integrated Security=True" SelectCommand="select * from Employee"></asp:SqlDataSource>--%>
        
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br /><br />
        <asp:Button ID="Button1" runat="server" Text="Button" />
        <asp:GridView ID="GridView1" runat="server" DataSourceID="SqlDataSource1"></asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" FilterExpression="Id=1" ProviderName="System.Data.SqlClient" ConnectionString="Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\DataSourceEx\DataSourceEx\App_Data\Database1.mdf;Integrated Security=True"  SelectCommand="select * from Employee"></asp:SqlDataSource>
    </div>
    </form>
</body>
</html>
