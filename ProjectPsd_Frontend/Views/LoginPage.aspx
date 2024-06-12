<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="ProjectPsd_Frontend.Views.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .error { color: red; }
    </style>
    <script type="text/javascript">
        function validateForm() {
            let valid = true;

            let username = document.getElementById('<%= Tb_Username.ClientID %>').value;
            if (username.trim() === "") {
                document.getElementById('usernameError').innerText = 'Username cannot be empty.';
                valid = false;
            } else {
                document.getElementById('usernameError').innerText = '';
            }

            let password = document.getElementById('<%= Tb_Password.ClientID %>').value;
            if (password.trim() === "") {
                document.getElementById('passwordError').innerText = 'Password cannot be empty.';
                valid = false;
            } else {
                document.getElementById('passwordError').innerText = '';
            }

            return valid;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="Tb_Username" runat="server"></asp:TextBox>
        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="Tb_Password" runat="server"></asp:TextBox>
        </div>
        <div>
        <asp:CheckBox ID="rememberMe" runat="server" Text="Remember Me" />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Login" OnClick="Button1_Click" />
        <asp:LinkButton ID="LinkButton_Register" runat="server" OnClick="LinkButton_Register_Click">Register</asp:LinkButton>
    </form>
</body>
</html>
