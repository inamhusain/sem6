<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="practical3_usingQueryString.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="FirstName"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtFirstname" runat="server"></asp:TextBox>
                    </td>
                </tr>       
                
                 <tr>
                    <td>
                        <asp:Label ID="Label2" runat="server" Text="lastName"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>
                    </td>
                </tr>        

                 <tr>
                    <td>
                        <asp:Label ID="Label3" runat="server" Text="RollNo"></asp:Label>
                    </td>
                    <td>
                        <asp:TextBox ID="txtRollno" runat="server"></asp:TextBox>
                    </td>
                </tr> 
                
                <tr>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
                    </td>
                </tr>  
            </table>
    
    </div>
    </form>
</body>
</html>
