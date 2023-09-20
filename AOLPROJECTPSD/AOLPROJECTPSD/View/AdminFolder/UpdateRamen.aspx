<%@ Page Title="" Language="C#" MasterPageFile="~/View/AdminFolder/admin.Master" AutoEventWireup="true" CodeBehind="UpdateRamen.aspx.cs" Inherits="AOLPROJECTPSD.View.AdminFolder.UpdateRamen" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Back_Button" runat="server" Text="<-" OnClick="Back_Button_Click" />
    <br />
    <br />

    <asp:Label ID="Label1" runat="server" Text="Name   = "></asp:Label>
    <asp:Label ID="Name_Label" runat="server" Text=""></asp:Label>
    <br />

    <asp:Label ID="Label2" runat="server" Text="Meat   = "></asp:Label>
    <asp:Label ID="Meat_Label" runat="server" Text=""></asp:Label>
    <br />

    <asp:Label ID="Label4" runat="server" Text="Broth  = "></asp:Label>
    <asp:Label ID="Broth_Label" runat="server" Text=""></asp:Label>
    <br />
        
    <asp:Label ID="Label6" runat="server" Text="Price  = "></asp:Label>
    <asp:Label ID="Price_Label" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Name   = "></asp:Label>
    <asp:TextBox ID="Name_Textbox" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="Label5" runat="server" Text="Pick NUMBER MEAT: 1. Chicken, 2. Beef, 3. Pork, 4. Eel, 5. Squid, 6. Fish"></asp:Label>
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
    <asp:Label ID="statusLbl" runat="server" Text=""></asp:Label><br />

    <asp:Button ID="Update_Button" runat="server" Text="Update" OnClick="Update_Button_Click" />
    <br />
    <asp:Button ID="Delete_Button" runat="server" Text="Delete" OnClick="Delete_Button_Click" />
</asp:Content>
