<%@ Page Title="" Language="C#" MasterPageFile="~/View/SellerFolder/seller.Master" AutoEventWireup="true" CodeBehind="InsertRamen.aspx.cs" Inherits="AOLPROJECTPSD.View.SellerFolder.InsertRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Back_Button" runat="server" Text="<-" OnClick="Back_Button_Click" />
    <br />
    <br />

    <asp:Label ID="Label3" runat="server" Text="Name   = "></asp:Label>
    <asp:TextBox ID="Name_Textbox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label1" runat="server" Text="Pick NUMBER MEAT: 1. Chicken, 2. Beef, 3. Pork, 4. Eel, 5. Squid, 6. Fish"></asp:Label>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Meat   = "></asp:Label>
    <asp:TextBox ID="Meat_Textbox" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label9" runat="server" Text="Broth  = "></asp:Label>
    <asp:TextBox ID="Broth_Textbox" runat="server"></asp:TextBox>
    <br />

    <asp:Label ID="Label11" runat="server" Text="Price = "></asp:Label>
    <asp:TextBox ID="Price_Textbox" runat="server"></asp:TextBox>
    <br />

    <asp:Button ID="Insert_Button" runat="server" Text="Insert" OnClick="Insert_Button_Click" />
    <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label>
</asp:Content>
