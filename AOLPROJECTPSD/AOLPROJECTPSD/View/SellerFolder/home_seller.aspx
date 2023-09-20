<%@ Page Title="" Language="C#" MasterPageFile="~/View/SellerFolder/seller.Master" AutoEventWireup="true" CodeBehind="home_seller.aspx.cs" Inherits="AOLPROJECTPSD.View.SellerFolder.home_seller" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="homeLbl" runat="server" Text="HOME"></asp:Label>
    <br />
    <asp:Label ID="roleLbl" runat="server" Text="Logged in as : Seller"></asp:Label>
    <br />
    <asp:Label ID="customerLbl" runat="server" Text="Customer Data"></asp:Label>
    <asp:GridView ID="customerdataGV" runat="server">
    </asp:GridView>
</asp:Content>