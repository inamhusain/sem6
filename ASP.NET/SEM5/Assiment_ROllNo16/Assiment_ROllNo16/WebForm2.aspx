<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Assiment_ROllNo16.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="css/StyleSheet1.css" rel="stylesheet" />
</head>
<body>
    <center>
    <form id="form1" runat="server">
    <div>

        <h1>Using Data Source</h1><br /><br />

    <asp:Label ID="Label1" runat="server" Text="Customer Id" CssClass="lable"></asp:Label><br />
        <asp:TextBox ID="txtID" runat="server" CssClass="textbox"></asp:TextBox><br /><br />

        <asp:Label ID="Label2" runat="server" Text="Name" CssClass="lable"></asp:Label><br />
        <asp:TextBox ID="txtName" runat="server" CssClass="textbox"></asp:TextBox><br /><br />

        <asp:Label ID="Label3" runat="server" Text="City" CssClass="lable"></asp:Label><br />

        <asp:DropDownList ID="DropDownList1" runat="server" Width="200px" CssClass="textbox">
            <asp:ListItem Value="Ahmedabad">Ahmedabad</asp:ListItem>
            <asp:ListItem Value="Surat">Surat</asp:ListItem>
            <asp:ListItem Value="Vadodara">Vadodara</asp:ListItem>
            <asp:ListItem Value="Rajkot">Rajkot</asp:ListItem>
            <asp:ListItem Value="Bhavnagar">Bhavnagar</asp:ListItem>
            <asp:ListItem Value="Jamnagar">Jamnagar</asp:ListItem>
            <asp:ListItem Value="Junagadh">Junagadh</asp:ListItem>
            <asp:ListItem Value="Gandhinagar">Gandhinagar</asp:ListItem>
            <asp:ListItem Value="Anand">Anand</asp:ListItem>
            <asp:ListItem Value="Navsari">Navsari</asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />

       <asp:Label ID="Label5" runat="server" Text="Gender" CssClass="lable"></asp:Label><br />
        
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="Male">Male</asp:ListItem>
            <asp:ListItem Value="Female">Female</asp:ListItem>
        </asp:RadioButtonList>
        <br /><br />

        <asp:Button ID="Button1" runat="server" Text="Insert"  OnClick="Insert" CssClass="btn" Width="120px"/>
        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Update" CssClass="btn" Width="119px"/>
        <asp:Button ID="Button3" runat="server" Text="Delete" OnClick="Delete" CssClass="btn" Width="121px"/>

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataSourceID="SqlDataSource1" EmptyDataText="No records has been added.">
            <Columns>
                <asp:BoundField DataField="CustomerId" HeaderText="id" />
                <asp:BoundField DataField="name" HeaderText="name" />
                <asp:BoundField DataField="city" HeaderText="city" />
                <asp:BoundField DataField="gender" HeaderText="Gender" />
            </Columns>

        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ProviderName="System.Data.SqlClient" ConnectionString="Data Source=(LocalDB)\v11.0;AttachDbFilename=E:\c#\Assiment_ROllNo16\Assiment_ROllNo16\App_Data\Database1.mdf;Integrated Security=True" SelectCommand="select CustomerId,Name,City,Gender from CustomerMaster" InsertCommand="insert into CustomerMaster (CustomerId,Name,City, Gender) values (@CustomerId,@name,@city,@gender)" UpdateCommand="update CustomerMaster set Name=@name ,City=@city, Gender=@gender Where CustomerId=@CustomerId" DeleteCommand="delete from CustomerMaster Where CustomerId=@CustomerId ">
                
            <InsertParameters>
                <asp:ControlParameter Name="CustomerId" ControlID="txtID" type="Int64" />
                <asp:ControlParameter Name="name" ControlID="txtName" Type="String"/>
                <asp:ControlParameter Name="city" ControlID="DropDownList1" Type="String" />
                <asp:ControlParameter Name="gender" ControlID="RadioButtonList1" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:ControlParameter Name="CustomerId" ControlID="txtID" type="Int64" />
                <asp:ControlParameter Name="name" ControlID="txtName" Type="String"/>
                <asp:ControlParameter Name="city" ControlID="DropDownList1" Type="String" />
                <asp:ControlParameter Name="gender" ControlID="RadioButtonList1" Type="String" />
            </UpdateParameters>
            <DeleteParameters>
                <asp:ControlParameter Name="CustomerId" ControlID="txtID" type="Int64" />
                <asp:ControlParameter Name="name" ControlID="txtName" Type="String"/>
                <asp:ControlParameter Name="city" ControlID="DropDownList1" Type="String" />
                <asp:ControlParameter Name="gender" ControlID="RadioButtonList1" Type="String" />
            </DeleteParameters>
        </asp:SqlDataSource>
        
    </div>
    </form>

    </center>
</body>
</html>
