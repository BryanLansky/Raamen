<%@ Page Title="" Language="C#" MasterPageFile="~/View/AdminFolder/admin.Master" AutoEventWireup="true" CodeBehind="home_admin.aspx.cs" Inherits="AOLPROJECTPSD.View.AdminFolder.home_admin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="homeLbl" runat="server" Text="HOME"></asp:Label>
    <br />
    <asp:Label ID="roleLbl" runat="server" Text="Logged in as : Admin"></asp:Label>
    <br />
    <asp:GridView ID="sellerdataGV" runat="server">
    </asp:GridView>
    <asp:GridView ID="buyerdataGV" runat="server">
    </asp:GridView>
</asp:Content>
