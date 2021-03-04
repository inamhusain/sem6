<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Assiment_ROllNo16.WebForm1" %>

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


        <asp:Button ID="Button6" runat="server" Text="Data Source" PostBackUrl="~/WebForm2.aspx" CssClass="btn"></asp:Button><br />



        <asp:Label ID="Label1" runat="server" Text="Customer Id" CssClass="lable"></asp:Label><br />
        <asp:TextBox ID="txtID" runat="server" CssClass="textbox"></asp:TextBox><br /><br />

        <asp:Label ID="Label2" runat="server" Text="Name" CssClass="lable"></asp:Label><br />
        <asp:TextBox ID="txtName" runat="server" CssClass="textbox"></asp:TextBox><br /><br />

        <asp:Label ID="Label3" runat="server" Text="City" CssClass="lable"></asp:Label><br />

        <asp:DropDownList ID="DropDownList1" runat="server" Width="200px" CssClass="textbox">
            <asp:ListItem Value="1">Ahmedabad</asp:ListItem>
            <asp:ListItem Value="2">Surat</asp:ListItem>
            <asp:ListItem Value="3">Vadodara</asp:ListItem>
            <asp:ListItem Value="4">Rajkot</asp:ListItem>
            <asp:ListItem Value="5">Bhavnagar</asp:ListItem>
            <asp:ListItem Value="6">Jamnagar</asp:ListItem>
            <asp:ListItem Value="7">Junagadh</asp:ListItem>
            <asp:ListItem Value="8">Gandhinagar</asp:ListItem>
            <asp:ListItem Value="9">Anand</asp:ListItem>
            <asp:ListItem Value="10">Navsari</asp:ListItem>
        </asp:DropDownList>

        <br />
        <br />

       <asp:Label ID="Label5" runat="server" Text="Gender" CssClass="lable"></asp:Label><br />
        
        <asp:RadioButtonList ID="RadioButtonList1" runat="server">
            <asp:ListItem Value="1">Male</asp:ListItem>
            <asp:ListItem Value="2">Female</asp:ListItem>
        </asp:RadioButtonList>
        <br /><br />

        <asp:Label ID="Label4" runat="server" Text="Hobbies" CssClass="lable"></asp:Label><br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server">
            <asp:ListItem Value="1">Swimming</asp:ListItem>
            <asp:ListItem Value="2">Driving</asp:ListItem>
            <asp:ListItem Value="3">Reading</asp:ListItem>
            <asp:ListItem Value="4">Playing</asp:ListItem>
        </asp:CheckBoxList>

        <br />

        <asp:Button ID="Button1" runat="server" Text="Insert" Width="117px" OnClick="Button1_insert"  CssClass="btn"/>
        
        <asp:Button ID="Button2" runat="server" Text="Update" Width="118px" OnClick="Button2_update"  CssClass="btn"/>
        
        <asp:Button ID="Button3" runat="server" Text="Delete" Width="117px" OnClick="Button3_Delete" CssClass="btn" />
       
        <asp:Button ID="Button4" runat="server" Text="Display" Width="117px" OnClick="Button4_Display"  CssClass="btn"/>
      
        <asp:Button ID="Button5" runat="server" Text="Search" Width="117px" OnClick="Button5_Search" CssClass="btn"/><br />



    </div>
    </form>
        </center>
</body>
</html>
