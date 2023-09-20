<%@ Page Title="" Language="C#" MasterPageFile="~/View/BuyerFolder/buyer.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="AOLPROJECTPSD.View.BuyerFolder.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Username = "></asp:Label>
    <asp:TextBox ID="Username_TextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Email    = "></asp:Label>
    <asp:TextBox ID="Email_TextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Gender   = "></asp:Label>
    <asp:TextBox ID="Gender_TextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label7" runat="server" Text="Password ="></asp:Label>
    <asp:TextBox ID="Password_TextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Confirm Password = "></asp:Label>
    <asp:TextBox ID="ConfirmPassword_TextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click" />
    <asp:Label ID="Info_Label" runat="server" Text=""></asp:Label>
</asp:Content>
