﻿<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="MasterPageExample.WebForm1" Title="Untitled Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>This is home page</h1>
    <asp:TextBox ID="TextBox1" runat="server" />
    <asp:TextBox ID="TextBox2" runat="server" />
    <asp:TextBox ID="TextBox3" runat="server" />
</asp:Content>
