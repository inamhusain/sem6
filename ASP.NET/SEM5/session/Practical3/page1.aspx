 

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page1.aspx.cs" Inherits="Practical3.page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
      <style>
        .main{
            margin:auto;
            width:50%;
            box-shadow: 0px 0px 8px 1px;
        }
        .main-h1{
            text-align:center;
            font-family: system-ui;
            letter-spacing: 5px;
            font-weight: 400;
        }
          .main-namelbl, .main-clglbl, .main-Rnolbl {
            font-family: system-ui;
            font-size: 13px;
            margin-left:27%;
          }
        .main-t1, .main-t2, .main-t3{
            display: block;
            border: none;
            background-color: transparent;
            border-bottom: 1px solid black;
            box-shadow: 1px 1px 1px 1px;
            padding: 0% 8% 0% 17%;
            margin-left: 27%;
            margin-bottom: 30px;
            font-size: 18px;
            font-family: system-ui;
            font-weight: 500;
            letter-spacing: 1px;
        }
        .main-btn{
            font-size: 14px;
            letter-spacing: 8px;
            font-family: system-ui;
            font-weight: 700;
            border: none;
            box-shadow: 0px 1px 6px 1px;
            margin-left: 42%;
            margin-bottom: 6%;
        }
    </style>
</head>




<body>
    <form id="form1" runat="server">
    <div class="main">
        <h1 class="main-h1">FILL THE FORM</h1>
        <asp:Label ID="Label1" runat="server" Text="Name" CssClass="main-namelbl"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server" Class="main-t1"></asp:TextBox>

        <asp:Label ID="Label2" runat="server" Text="Collage Name" CssClass="main-clglbl"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server" Class="main-t2"></asp:TextBox>

        <asp:Label ID="Label3" runat="server" Text="Roll No" CssClass="main-Rnolbl"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server" Class="main-t3"></asp:TextBox>

        <asp:Button ID="Button1" runat="server" Text="SUBMIT" OnClick="Button1_Click" class="main-btn"/>
    </div>






    </form>
</body>
</html>
