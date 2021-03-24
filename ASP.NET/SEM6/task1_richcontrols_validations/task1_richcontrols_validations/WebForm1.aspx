<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="task1_richcontrols_validations.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <center>
    <form id="form1" runat="server">
    <div>
        <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex="0">
            <%-- Personal Information view --%>
            <asp:View ID="PersonalInfo" runat="server">
                <h2>Personal Information</h2>
                <%-- Name --%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtname" ErrorMessage="Please Enter Name" ForeColor="red"></asp:RequiredFieldValidator><br />
                <asp:TextBox ID="txtname" runat="server" placeholder="Name" Width="335px"></asp:TextBox><br />
                <%-- Email --%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtemail" ErrorMessage="Please Enter Email" ForeColor="red"></asp:RequiredFieldValidator>
                &nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemail" ErrorMessage="Enter Valid Email" ValidationExpression="\D+\S+\@\S+\.\S+" ForeColor="red"></asp:RegularExpressionValidator><br />
                <asp:TextBox ID="txtemail" runat="server" placeholder="Email" Width="334px"></asp:TextBox><br /><br />
                <%-- DOB --%>
                <asp:Label ID="Label1" runat="server" Text="Select Date Of Birth"></asp:Label>
                 <asp:Calendar ID="Calendar1" OnSelectionChanged="selectDate" runat="server" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="16px" SelectWeekText="" Width="342px">
                    <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                    <NextPrevStyle VerticalAlign="Bottom" />
                    <OtherMonthDayStyle ForeColor="#808080" />
                    <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                    <SelectorStyle BackColor="#CCCCCC" />
                    <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                    <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                    <WeekendDayStyle BackColor="#FFFFCC" />
                </asp:Calendar><br />
                <asp:Label ID="txtdateError" runat="server" Text=""></asp:Label>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtdate" ErrorMessage="Please Enter Date" ForeColor="red"></asp:RequiredFieldValidator><br />
                <asp:TextBox ID="txtdate" runat="server" placeholder="DOB"></asp:TextBox><br /><br />
                <%-- Address --%>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtdate" ErrorMessage="Please Enter address" ForeColor="red"></asp:RequiredFieldValidator><br />
                <asp:TextBox ID="txtaddress" runat="server" placeholder="Address"></asp:TextBox><br /><br />
                <%-- btn --%>
                <br /><asp:Button runat="server" ID="btnPersonalNext" Text="Next" OnClick="btnPersonalNext_Click" />
            </asp:View>
            <%-- Qulification information view --%>
            <asp:View ID="QulificationInfornation" runat="server">
                <h2>Qulificaion Information</h2><br />
                <%-- std 10 --%>
                <asp:Label ID="Label2" runat="server" Text="STD 10"></asp:Label><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtstd10Board" ErrorMessage="Please Enter BoardName" ForeColor="red"></asp:RequiredFieldValidator><br />
                <asp:TextBox ID="txtstd10Board" runat="server" placeholder="Board" Width="335px"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtstd10Per" ErrorMessage="Please Enter Per%" ForeColor="red"></asp:RequiredFieldValidator><br />
                <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Per must be  between 35% to 100%" MinimumValue="34.99" MaximumValue="99.99" ControlToValidate="txtstd10Per" ForeColor="red"></asp:RangeValidator><br />
                <asp:TextBox ID="txtstd10Per" runat="server" placeholder="Per%" Width="335px" TextMode="Number"></asp:TextBox><br /><br />
                <%-- std 12 --%>
                <asp:Label ID="Label3" runat="server" Text="STD 12"></asp:Label><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtstd12Board" ErrorMessage="Please Enter BoardName" ForeColor="red"></asp:RequiredFieldValidator><br />
                <asp:TextBox ID="txtstd12Board" runat="server" placeholder="Board" Width="335px"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtstd12Per" ErrorMessage="Please Enter Per%" ForeColor="red"></asp:RequiredFieldValidator><br />
                <asp:RangeValidator ID="RangeValidator2" runat="server" ErrorMessage="Per must be  between 35% to 100%" MinimumValue="34.99" MaximumValue="99.99" ControlToValidate="txtstd12Per" ForeColor="red"></asp:RangeValidator><br />
                <asp:TextBox ID="txtstd12Per" runat="server" placeholder="Per%" Width="335px" TextMode="Number"></asp:TextBox><br /><br />
                 <%-- CLG --%>
                <asp:Label ID="Label4" runat="server" Text="STD 12"></asp:Label><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtclgBoard" ErrorMessage="Please Enter BoardName" ForeColor="red"></asp:RequiredFieldValidator><br />
                <asp:TextBox ID="txtclgBoard" runat="server" placeholder="Univercity" Width="335px"></asp:TextBox><br />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator10" runat="server" ControlToValidate="txtclgPer" ErrorMessage="Please Enter Per%" ForeColor="red"></asp:RequiredFieldValidator><br />
                <asp:RangeValidator ID="RangeValidator3" runat="server" ErrorMessage="SGPA must be 1 to 10" ControlToValidate="txtclgPer" ForeColor="red" MinimumValue="0" MaximumValue="10" Type="Integer"></asp:RangeValidator><br />
                <asp:TextBox ID="txtclgPer" runat="server" placeholder="SGPA" Width="335px"></asp:TextBox><br /><br />
                <%-- btn  --%>
                <asp:Button runat="server" ID="Button1" Text="Prev" OnClick="btnQulificationPrv_Click" Width="110px" />
                <asp:Button runat="server" ID="Button2" Text="Next" OnClick="btnQulificationNext_Click" Width="109px" />
            </asp:View>
            <%-- cmt --%>
            <asp:View ID="comANDsugg" runat="server">
                <h2>Suggession or comment</h2>
                <asp:TextBox ID="txtcmt" runat="server" Width="432px" Height="111px" placeholder="Suggession And Comment"></asp:TextBox><br /><br />
                <asp:Button runat="server" ID="Button3" Text="Submit" OnClick="btnsubmit_Click" Width="109px" />
            </asp:View>
        </asp:MultiView>
    </div>
    </form>
        </center>
</body>
</html>
