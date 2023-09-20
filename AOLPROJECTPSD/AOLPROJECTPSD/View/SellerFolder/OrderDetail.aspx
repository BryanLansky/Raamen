<%@ Page Title="" Language="C#" MasterPageFile="~/View/SellerFolder/seller.Master" AutoEventWireup="true" CodeBehind="OrderDetail.aspx.cs" Inherits="AOLPROJECTPSD.View.SellerFolder.OrderDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Transaction Id = "></asp:Label>
    <asp:Label ID="Transaction_Id_Label" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Customer Name  ="></asp:Label>
    <asp:Label ID="Customer_Name_Label" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Ramen Name     ="></asp:Label>
    <asp:Label ID="RamenName_Label" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Price Total    ="></asp:Label>
    <asp:Label ID="Price_Total_Label" runat="server" Text=""></asp:Label>
</asp:Content>
