<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="P5.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <center>
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <br />
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                &nbsp;
                <h1><asp:Label ID="lblhr" runat="server" Text="00" ForeColor="Red"></asp:Label></h1> &nbsp;Hour, 
                <h1><asp:Label ID="lblmin" runat="server" Text="00" ForeColor="Red"></asp:Label></h1> &nbsp;Min,   
                <h1><asp:Label ID="lblsec" runat="server" Text="00" ForeColor="Red"></asp:Label></h1> &nbsp;Sec. 
                <asp:Timer ID="Timer1" runat="server" OnTick="ontick" Interval="1000" ></asp:Timer>
                <br><br>
                <asp:Button ID="btnStart" runat="server" OnClick="btnStart_Click" Text="Start" />
                &nbsp;&nbsp;
                <asp:Button ID="btnStop" runat="server" OnClick="btnStop_Click" Text="Stop" />
                &nbsp;&nbsp;
                <asp:Button ID="btnReset" runat="server" OnClick="btnReset_Click" Text="Reset" />
           

            </ContentTemplate>
        </asp:UpdatePanel>
            </center>
    </div>
        
    </form>
</body>
</html>
