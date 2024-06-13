<%@ Page Title="" Language="C#" MasterPageFile="~/Layouts/MainTemplate.Master" AutoEventWireup="true" CodeBehind="OrderMakeupPage.aspx.cs" Inherits="ProjectPsd_Frontend.Views.OrderMakeupPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Cart</h1>
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CartID" HeaderText="CartID" SortExpression="CartID" />
            <asp:BoundField DataField="MakeupID" HeaderText="MakeupID" SortExpression="MakeupID" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        </Columns>
    </asp:GridView>
    <asp:Button ID="clsAll" runat="server" Text="Clear All" />
    <asp:Button ID="checkout" runat="server" Text="Checkout" />
    
    <hr />
    <h1>Items</h1>
    <asp:GridView ID="GridView" runat="server" AutoGenerateColumns="False" >
    <Columns>
        <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName" />
        <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice" />
        <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight" />
        <asp:BoundField DataField="MakeupType" HeaderText="MakeupType" SortExpression="MakeupType" />
        <asp:BoundField DataField="MakeupBrand" HeaderText="MakeupBrand" SortExpression="MakeupBrand" />
    </Columns>
</asp:GridView>
    
    <asp:GridView ID="GridView3" runat="server" AutoGenerateColumns="False" >
        <Columns>
            <asp:BoundField DataField="MakeupName" HeaderText="MakeupName" SortExpression="MakeupName" />
            <asp:BoundField DataField="MakeupPrice" HeaderText="MakeupPrice" SortExpression="MakeupPrice" />
            <asp:BoundField DataField="MakeupWeight" HeaderText="MakeupWeight" SortExpression="MakeupWeight" />
            <asp:BoundField DataField="MakeupType" HeaderText="MakeupType" SortExpression="MakeupType" />
            <asp:BoundField DataField="MakeupBrand" HeaderText="MakeupBrand" SortExpression="MakeupBrand" />
        </Columns>
    </asp:GridView>
    <div>
        <asp:TextBox ID="quantity" runat="server" placeholder="Quantity"></asp:TextBox>
    </div>
    <asp:Label ID="LabelValidasi" runat="server" Text=""></asp:Label>
    
    
</asp:Content>

