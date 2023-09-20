<%@ Page Title="" Language="C#" MasterPageFile="~/View/AdminFolder/admin.Master" AutoEventWireup="true" CodeBehind="ManageRamen.aspx.cs" Inherits="AOLPROJECTPSD.View.AdminFolder.ManageRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="Ramen_Gridview" runat="server"></asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Input Id Ramen"></asp:Label>
    <asp:TextBox ID="idramenTextbox" runat="server"></asp:TextBox>
    <asp:Button ID="Update_Button" runat="server" Text="Update" OnClick="Update_Button_Click" />
    <br />
    <asp:Button ID="Insert_Button" runat="server" Text="Insert New Ramen" OnClick="Insert_Button_Click" />
</asp:Content>
