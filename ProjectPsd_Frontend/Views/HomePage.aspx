<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainTemplate.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ProjectPsd_Frontend.Views.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Label ID="LblUserInfo" runat="server" Text=""></asp:Label>
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </div>
</asp:Content>
