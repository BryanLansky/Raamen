<%@ Page Title="" Language="C#" MasterPageFile="~/View/SellerFolder/seller.Master" AutoEventWireup="true" CodeBehind="OrderQueue.aspx.cs" Inherits="AOLPROJECTPSD.View.SellerFolder.OrderQueue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="Transaction_Done_Gridview" runat="server"></asp:GridView>
    <br />
    <asp:GridView ID="Transaction_Unhandled_Gridview" runat="server"></asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Unhandled Transaction Id = "></asp:Label>
    <asp:TextBox ID="unhandled_Transaction_id_Textbox" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Handle_Button" runat="server" Text="Handle" OnClick="Handle_Button_Click" />
</asp:Content>
