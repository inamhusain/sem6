<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="repeateddataBinding.aspx.cs" Inherits="SingleDatabinding.repeateddataBinding" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="ListBox1" runat="server"></asp:ListBox>

        <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>

        <asp:RadioButtonList ID="RadioButtonList1" runat="server"></asp:RadioButtonList>

        <asp:CheckBoxList ID="CheckBoxList1" runat="server"></asp:CheckBoxList>

    </div>
    </form>
</body>
</html>
