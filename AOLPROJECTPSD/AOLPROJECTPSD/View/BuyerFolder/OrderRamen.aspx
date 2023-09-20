<%@ Page Title="" Language="C#" MasterPageFile="~/View/BuyerFolder/buyer.Master" AutoEventWireup="true" CodeBehind="OrderRamen.aspx.cs" Inherits="AOLPROJECTPSD.View.BuyerFolder.OrderRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="Ramen_GridView" runat="server"></asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Ramen Id = "></asp:Label> 
    <asp:TextBox ID="Id_Ramen_TextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Quantity = "></asp:Label> 
    <asp:TextBox ID="Quantity_TextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Add_Button" runat="server" Text="Add" OnClick="Add_Button_Click" /><br />
    <asp:Button ID="Clear_Button" runat="server" Text="Clear Cart" OnClick="Clear_Button_Click" /><br />
    <asp:Button ID="Buy_Button" runat="server" Text="Buy Cart" OnClick="Buy_Button_Click" /><br />
</asp:Content>
