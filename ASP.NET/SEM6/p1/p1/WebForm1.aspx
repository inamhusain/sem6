

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="p1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <script>
      
  </script>
      <script type="text/javascript">   
          <%--function validate() {
              var txt = document.getElementById('<%= txtname.ClientID %>');
            if (txt.value == "") {
                txt.style.border = "1px solid red";
                return false;
            }
        }--%>
        function vallength(sender, args)
        {
            
            if (args.Value.length < 5) {
                return args.IsValid = false;
            }
            else
            {
                return args.IsValid = true;
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ShowSummary="true" DisplayMode="List"/>
        <%-- TEXT REQ --%>
        <asp:TextBox ID="txtname" runat="server" placeholder="name"></asp:TextBox>
        <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
        <%-- Display="Dynamic" ValidationGroup="submit" --%>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" Display="Dynamic" Text="*" SetFocusOnError="true" ValidationGroup="submit" runat="server"  ErrorMessage="Enter NAME" ForeColor="red" ControlToValidate="txtname"></asp:RequiredFieldValidator><br><br>
        <asp:CustomValidator  OnServerValidate="csmval" ControlToValidate="txtname" ID="CustomValidator1" runat="server" ErrorMessage="enter valid text"></asp:CustomValidator><br />
        <%-- ClientValidationFunction="vallength" --%>
        <%-- ADDRESS  REQ --%>
        <asp:TextBox ID="txtaddress" runat="server" placeholder="address"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" Text="*" SetFocusOnError="true" ErrorMessage="Enter ADDRESS" ForeColor="red" ControlToValidate="txtaddress"></asp:RequiredFieldValidator><br><br>
        <%-- email REQ  + regular --%>
        <asp:TextBox ID="txtemail" runat="server" placeholder="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" Text="*" ErrorMessage="Enter EMAIL" ForeColor="red" ControlToValidate="txtemail"></asp:RequiredFieldValidator><br />
        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ErrorMessage="Enter valid Email" ControlToValidate="txtemail" ValidationExpression="\D+\S+\@\S+\.\S+"></asp:RegularExpressionValidator><br><br>      
          <%-- PASS REQ + COMPARE --%>
        <asp:TextBox ID="txtpass" TextMode="Password" runat="server" placeholder="pass"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" Text="*" ErrorMessage="Enter PASSWORD" ForeColor="red" ControlToValidate="txtpass"></asp:RequiredFieldValidator><br><br>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Enter valid password (must be 4 to 10 char)" ControlToValidate="txtpass" ValidationExpression="\w{4,10}"></asp:RegularExpressionValidator><br><br>      
        <asp:TextBox ID="txtcpass" TextMode="Password" runat="server" placeholder="c-pass"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" Text="*" ErrorMessage="Enter PASSWORD" ForeColor="red" ControlToValidate="txtcpass"></asp:RequiredFieldValidator><br>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Password Not Match" ControlToCompare="txtpass" ControlToValidate="txtcpass"></asp:CompareValidator><br>    
        <%--age req + rang --%>
        <asp:TextBox ID="txtage" runat="server" placeholder="age"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" Text="*" ErrorMessage="Enter AGE" ForeColor="red" ControlToValidate="txtage"></asp:RequiredFieldValidator><br>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Enter valid age(must be 18 to 40)" ControlToValidate="txtage" ForeColor="red" MinimumValue="18" MaximumValue="40" type="Integer" ></asp:RangeValidator><br />

        <asp:Button ID="Button1" runat="server" Text="submit" OnClientClick="return validate();"  CausesValidation="true"/><br>
        <%-- OnClientClick="return validate();" --%>

    </div>
    </form>













</body>
</html>
