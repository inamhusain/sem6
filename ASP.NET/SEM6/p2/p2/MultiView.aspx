<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MultiView.aspx.cs" Inherits="p2.MultiView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <asp:View ID="PersonalInfo" runat="server">
                <h2>Personal Information</h2>
                <table>
                    <tr>
                        <th>Name : </th>
                        <td><asp:TextBox ID="txtname" runat="server" placeholder="Name"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>Address : </th>
                        <td><asp:TextBox ID="TextBox2" runat="server" TextMode="MultiLine" placeholder="Address"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                        <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" style="height: 35px" />
                        </td>
                    </tr>
                </table>
            </asp:View>
            <asp:View ID="QulificationInfo" runat="server">
                <h2>Qulification Information</h2>
                <table>
                    <tr>
                        <th>Std 10(%) : </th>
                        <td><asp:TextBox ID="TextBox1" runat="server" TextMode="Number" placeholder="std 10(%)"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <th>Std 12(%) : </th>
                        <td><asp:TextBox ID="TextBox3" runat="server" TextMode="Number" placeholder="Std 12(%)"></asp:TextBox></td>
                    </tr>
                    <tr>
                        <td>
                        <asp:Button ID="Button2" runat="server" Text="Button" style="height: 35px" OnClick="Button2_Click" />
                        </td>
                    </tr>
                </table>
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
</body>
</html>
