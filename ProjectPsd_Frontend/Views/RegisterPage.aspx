<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ProjectPsd_Frontend.Views.RegisterPage" %>

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

            let username = document.getElementById('<%= TextBox_Username.ClientID %>').value;
            if (username.length < 5 || username.length > 15) {
                document.getElementById('usernameError').innerText = 'Username must be between 5 and 15 characters.';
                valid = false;
            } else {
                document.getElementById('usernameError').innerText = '';
            }

            let email = document.getElementById('<%= TextBox_Email.ClientID %>').value;
            if (!email.endsWith('.com')) {
                document.getElementById('emailError').innerText = 'Email must end with ".com".';
                valid = false;
            } else {
                document.getElementById('emailError').innerText = '';
            }

            let male = document.getElementById('<%= CheckBox_Male.ClientID %>').checked;
            let female = document.getElementById('<%= CheckBox_Female.ClientID %>').checked;
            if (!male && !female) {
                document.getElementById('genderError').innerText = 'Gender must be chosen.';
                valid = false;
            } else {
                document.getElementById('genderError').innerText = '';
            }

            let password = document.getElementById('<%= TextBox_Password.ClientID %>').value;
            let confirmPassword = document.getElementById('<%= TextBox_Confirmation.ClientID %>').value;
            if (password !== confirmPassword || password.length === 0) {
                document.getElementById('passwordError').innerText = 'Passwords must match and cannot be empty.';
                document.getElementById('confirmPasswordError').innerText = 'Passwords must match and cannot be empty.';
                valid = false;
            } else {
                document.getElementById('passwordError').innerText = '';
                document.getElementById('confirmPasswordError').innerText = '';
            }

            let dob = document.getElementById('<%= Calendar_dob.ClientID %>').value;
            if (!dob) {
                document.getElementById('dobError').innerText = 'Date of Birth cannot be empty.';
                valid = false;
            } else {
                document.getElementById('dobError').innerText = '';
            }

            return valid;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TextBox_Username" runat="server"></asp:TextBox>
            <span id="usernameError" class="error"></span>

        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox_Email" runat="server"></asp:TextBox>
            <span id="emailError" class="error"></span>
           
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
            <asp:CheckBox ID="CheckBox_Male" runat="server" Text="Male" GroupName="Gender" />
            <asp:CheckBox ID="CheckBox_Female" runat="server" Text="Female" GroupName="Gender" />
            <span id="genderError" class="error"></span>

        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox_Password" runat="server"></asp:TextBox>
            <span id="passwordError" class="error"></span>
           
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Confirmation Password"></asp:Label>
            <asp:TextBox ID="TextBox_Confirmation" runat="server"></asp:TextBox>
            <span id="confirmPasswordError" class="error"></span>
           
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Date of Birth"></asp:Label>
            <asp:Calendar ID="Calendar_dob" runat="server"></asp:Calendar>
            <span id="dobError" class="error"></span>

        </div>
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
    </form>
</body>
</html>
