<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calender.aspx.cs" Inherits="p2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Calendar ID="Calendar1" runat="server" ForeColor="#663399" BackColor="#FFFFCC" BorderColor="#FFCC66" Height="337px" SelectedDate="2021-03-05" ShowGridLines="True" Width="632px" OnSelectionChanged="calandertext" BorderWidth="1px" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt">
            <DayHeaderStyle BackColor="#FFCC66" Font-Bold="True" Height="1px" />
            <NextPrevStyle Font-Size="9pt" ForeColor="#FFFFCC" />
            <OtherMonthDayStyle ForeColor="#CC9966" />
            <SelectedDayStyle BackColor="#CCCCFF" Font-Bold="True" />
            <SelectorStyle BackColor="#FFCC66" />
            <TitleStyle BackColor="#990000" Font-Bold="True" Font-Size="9pt" ForeColor="#FFFFCC" />
            <TodayDayStyle BackColor="#FFCC66" ForeColor="White" />
        </asp:Calendar>
    </div>
        <p>&nbsp;</p>
        <p>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        </p>
        </form>
    
</body>
</html>
