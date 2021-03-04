<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login_sucess.aspx.cs" Inherits="logintest.login_sucess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/animejs/2.0.2/anime.min.js"></script>
    <style>
        .main{
            
            width:40%;
            margin:auto;
            font-family: system-ui;
            box-shadow: 0px 1px 5px 1px;
            background-color: greenyellow;
            margin-top:20%;
        }
        .ml9 {
          position: relative;
          font-weight: 200;
          font-size: 4em;
        }

        .ml9 .text-wrapper {
          position: relative;
          display: inline-block;
          padding-top: 0.2em;
          padding-right: 0.05em;
          padding-bottom: 0.1em;
          overflow: hidden;
        }

        .ml9 .letter {
          transform-origin: 50% 100%;
          display: inline-block;
          line-height: 1em;
          margin-left:10px;
        }
        .homebtn{
          width: auto;
          letter-spacing: 5px;
          padding: 5px 20px 5px 20px;
          margin-left: 43%;
          border: none;
          background-color: lightgray;
        }
        .homebtn:hover{
            background-color:#adff2f;
            transition-duration: 1s;
        }
    </style>

</head>
<body>
    <form id="form1" runat="server">
    <div class="main">
        <h1 class="ml9">
        <span class="text-wrapper">
            <span class="letters">Login Successful</span>
            </span>
        </h1>
        
    </div>
        <asp:Button ID="Button1" runat="server" Text="...Click Me..." CssClass="homebtn" OnClick="onclick"/>
    </form>

    
    <script>
        var textWrapper = document.querySelector('.ml9 .letters');
        textWrapper.innerHTML = textWrapper.textContent.replace(/\S/g, "<span class='letter'>$&</span>");

        anime.timeline({loop: true})
          .add({
              targets: '.ml9 .letter',
              scale: [0, 1],
              duration: 1500,
              elasticity: 600,
              delay: (el, i) => 45 * (i+1)
          })
            .add({
              targets: '.ml9',
              opacity: 0,
              duration: 1000,
              easing: "easeOutExpo",
              delay: 1000
          });
    </script>
</body>
</html>
