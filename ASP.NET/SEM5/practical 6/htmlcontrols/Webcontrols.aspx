<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Webcontrols.aspx.cs" Inherits="htmlcontrols.Webcontrols" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Wen contols</title>

     <style>

          .loading {
            position:fixed;
            width:100%;
            height:100vh;
            background:#f0f0f0 url('Images/Infinity-2.1s-200px.gif') no-repeat center;
            z-index:999999;
            
        }
        .title
        {
            font-size: 30px;
	        letter-spacing: 7px;
	        font-weight: 900;
        }
        .main
        {
            width: 80%;
            margin: auto;
            background-color: #f0f0f0;
            text-align: center;
            padding: 10px;
            margin-bottom: 100px;
        }
        a{text-decoration:none;}
    </style>
</head>
<body onload="Myfunc()">

    <div class="loading" id="loading"></div>

    <form id="form1" runat="server">
        <div class="main">
            
            <asp:Label ID="Label1" runat="server" Text="Web controls" CssClass="title"></asp:Label><hr />

            <asp:Label ID="Label2" runat="server" Text="Use of Button"></asp:Label><br />
            <asp:Button ID="Button1" runat="server" Text="Html Controls" PostBackUrl="~/htmlcontrols.aspx"/>
            <asp:Button ID="Button2" runat="server" Text="web controls" PostBackUrl="~/Webcontrols.aspx" /><br /><hr />

             <asp:Label ID="Label3" runat="server" Text="Use of Calender"></asp:Label><br />
            <center><asp:Calendar ID="Calendar1" runat="server"></asp:Calendar></center><br /><hr />


            <asp:Label ID="Label4" runat="server" Text="Use of Checkbox"></asp:Label><br />
            <asp:CheckBox ID="CheckBox1" runat="server" text="1" Checked/>

            <asp:CheckBox ID="CheckBox2" runat="server" text="2"/>
            <asp:CheckBox ID="CheckBox3" runat="server" text="3"/>
            <asp:CheckBox ID="CheckBox4" runat="server" text="4"/>
            <asp:CheckBox ID="CheckBox5" runat="server" text="5"/><hr />

            <asp:Label ID="Label5" runat="server" Text="Use of file upload"></asp:Label><br />
            <asp:FileUpload ID="FileUpload1" runat="server" /><hr />

            <asp:Label ID="Label6" runat="server" Text="Use of Hyperlink"></asp:Label><br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="https://inamhusain.github.io/">Go to my WebPage</asp:HyperLink><hr />

            
            <asp:Label ID="Label7" runat="server" Text="Use of image tag"></asp:Label><br />
            <asp:Image ID="Image1" runat="server"  ImageUrl="~/Images/bullet.png"/><hr />

            <asp:Label ID="Label8" runat="server" Text="Use of radiobutton"></asp:Label><br />
            <asp:RadioButton ID="RadioButton1" runat="server" GroupName="gender" text="Male" Checked/>
            <asp:RadioButton ID="RadioButton2" runat="server" GroupName="gender" text="Female"/><hr />

            <asp:Label ID="Label9" runat="server" Text="Use of TextBox"></asp:Label><br />
            <asp:TextBox ID="TextBox1" runat="server" placeholder="Email"  TextMode="Email"></asp:TextBox>
             <asp:TextBox ID="TextBox2" runat="server" placeholder="Password" textmode="Password"></asp:TextBox>
        </div>    
    </form>
     <script>

         var preloder = document.getElementById('loading');

         function Myfunc() {
             setTimeout(function () {
                 preloder.style.display = "none";
             }, 1500);

         }

    </script>
</body>
</html>
