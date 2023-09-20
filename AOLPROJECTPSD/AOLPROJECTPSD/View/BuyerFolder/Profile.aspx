<%@ Page Title="" Language="C#" MasterPageFile="~/View/BuyerFolder/buyer.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="AOLPROJECTPSD.View.BuyerFolder.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Username = "></asp:Label>
    <asp:Label ID="Username_Label" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Email    = "></asp:Label>
    <asp:Label ID="Email_Label" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Gender   = "></asp:Label>
    <asp:Label ID="Gender_Label" runat="server" Text=""></asp:Label>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Password ="></asp:Label>
    <asp:Label ID="Password_Label" runat="server" Text=""></asp:Label>
    <br />

    <asp:Button ID="Update_Button" runat="server" Text="Update Data" OnClick="Update_Button_Click" />
</asp:Content>
