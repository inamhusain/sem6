<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="htmlcontrols.aspx.cs" Inherits="htmlcontrols.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>practical 6</title>
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
     <asp:Button ID="Button1" runat="server" Text="Html Controls" PostBackUrl="~/htmlcontrols.aspx"/>
     <asp:Button ID="Button2" runat="server" Text="web controls" PostBackUrl="~/Webcontrols.aspx" /><br /><hr />

        <label class="title">Html controls</label><br /><hr />
        
        <a href="https://inamhusain.github.io/"> My Web</a><br />
        <label> 'a' tag is use for set link in text</label><br /><hr />

        <button value="Button" type="submit" style="width: 173px">Button</button><br />
        <label>'Button' tag is use for create button</label><br /><hr />
        
        <img src="Images/bullet.png"/><br />
        <asp:Label ID="Label4" runat="server" Text=" 'img' tag is use for Add image in our web page"></asp:Label><br /><hr />

        <input type="checkbox" checked />
            <label>1</label>    <br />
        <input type="checkbox"/>
            <label>2</label>    <br />
        <input type="checkbox"/>
            <label>3</label>    <br />
        <input type="checkbox"/>    
            <label>4</label>    <br />
        <input type="checkbox"/>    
            <label>5</label>    <br />

        <label >'checkbox' tag is use for select multiple choices</label><br /><hr />
        
        
        <input type="radio" id="male" name="gender" value="male" checked />
            <label>Male</label><br />
        <input type="radio" id="female" name="gender" value="female" />
            <label>Female</label><br />
        <label>'radio' tag is use for select one choice from multiple choices</label><br /><hr />

        <input type="text" placeholder="text" /><br />
        <input type="password" placeholder="password" /><br />
        <label>'text' tag is use for write text</label><br /><hr />

        <input type="file" /><br />
        <label>'file' tag is use for upload file</label><br /><hr />

     
        <input type="image"  src="Images/bullet.png"/><br />
        <label >'Image' tag is use for show image and set link in image</label><br /><hr />
    </div>
   </form>

    <script>

        var preloder = document.getElementById('loading');

        function Myfunc()
        {
            setTimeout(function () {
                preloder.style.display = "none";
            }, 1500);
            
        }

    </script>
</body>
</html>

















