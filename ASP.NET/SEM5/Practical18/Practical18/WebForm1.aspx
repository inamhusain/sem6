<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Practical18.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <!-- Latest compiled and minified CSS -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/css/bootstrap.min.css"/>

    <!-- jQuery library -->
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>

    <!-- Popper JS -->
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>

    <!-- Latest compiled JavaScript -->
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.2/js/bootstrap.min.js"></script>
   
     <!--Google Fonts-->
    <link rel="preconnect" href="https://fonts.gstatic.com" />
    <link href="https://fonts.googleapis.com/css2?family=Mulish:wght@300&display=swap" rel="stylesheet" />
    <!-- Sweetalert-->
    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>
    <!-- Css -->
    <link href="css/Style.css" rel="stylesheet" />

</head>


<body>
    <form id="form1" runat="server">
      <div id="main-con">
          <div class="container">
          <div class="row justify-content-center h-100">
              <div class="col-md-8 text-center my-auto" id="login-pak">
                  <h1> Login </h1>
                 
                        <div class="row justify-content-center">
                            <div class="col-md-8 text-center">
                                
                                
                                <asp:Label ID="lblUserName" runat="server" Text="UserName"></asp:Label>
                                <asp:TextBox ID="txtUserName" runat="server" placeholder="USERNAME"></asp:TextBox>
                            
                            
                            </div>
                        </div>
                        <div class="row justify-content-center">
                            <div class="col-md-8 text-center">
                                
                                
                                <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                                <asp:TextBox ID="txtPassword" runat="server" placeholder="PASSWORD"></asp:TextBox>
                            
                            
                            </div>
                        </div>
                          <hr />
                        <asp:Button ID="btnsubmit" runat="server" Text="Login" OnClick="btnsubmit_Click" /> 
              </div>  
          </div>
      </div>
      </div>
    </form>
</body>
</html>
