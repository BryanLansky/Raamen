<%@ Page Title="" Language="C#" MasterPageFile="~/View/AdminFolder/admin.Master" AutoEventWireup="true" CodeBehind="History.aspx.cs" Inherits="AOLPROJECTPSD.View.AdminFolder.History" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="Transaction_GridView" runat="server"></asp:GridView>
    <asp:Label ID="Label1" runat="server" Text="Transaction Id = "></asp:Label>
    <asp:TextBox ID="TransactionId_TextBox" runat="server"></asp:TextBox>
    <br />
    <asp:Button ID="CheckTransaction_Button" runat="server" Text="Check" OnClick="CheckTransaction_Button_Click"/>
    <asp:Label ID="Info_Label" runat="server" Text=""></asp:Label>
</asp:Content>
