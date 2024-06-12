<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="ProjectPsd_Frontend.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="TextBox_Username" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox_Username" ErrorMessage="Length must be between 5 and 15 alphabet, must be unique, and cannot be empty."></asp:RequiredFieldValidator>

        </div>
        <div>
            <asp:Label ID="Label2" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="TextBox_Email" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox_Email" ErrorMessage="Must ends with ‘.com’ and cannot be empty."></asp:RequiredFieldValidator>
           
        </div>
        <div>
            <asp:Label ID="Label3" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButton ID="RadioButton_Male" runat="server" GroupName="Gender" Text="Male" />
            <asp:RadioButton ID="RadioButton_Female" runat="server" GroupName="Gender" Text="Female" />
        </div>
        <div>
            <asp:Label ID="Label4" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="TextBox_Password" runat="server"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox_Password" ErrorMessage="Must be the same with confirm password, alphanumeric and cannot be empty."></asp:RequiredFieldValidator>
           
        </div>
        <div>
            <asp:Label ID="Label5" runat="server" Text="Confirmation Password"></asp:Label>
            <asp:TextBox ID="TextBox_Confirmation" runat="server"></asp:TextBox>
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox_Password" ControlToValidate="TextBox_Confirmation" ErrorMessage="Must be the same with password and cannot be empty."></asp:CompareValidator>
           
        </div>
        <div>
            <asp:Label ID="Label6" runat="server" Text="Date of Birth"></asp:Label>
            <asp:Calendar ID="Calendar_dob" runat="server"></asp:Calendar>
        </div>
        <div>
            <asp:Label ID="ErrorMessageLabel" runat="server" ForeColor="Red" Visible="false"></asp:Label>
        </div>
        <asp:Button ID="Button1" runat="server" Text="Register" OnClick="Button1_Click" />
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Login</asp:LinkButton>
    </form>
</body>
</html>
