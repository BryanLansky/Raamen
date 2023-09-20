<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="AOLPROJECTPSD.View.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="loginLbl" runat="server" Text="LOGIN"></asp:Label>
        <br />
        <asp:Label ID="UsernameLbl" runat="server" Text="Username"></asp:Label>
        <asp:TextBox ID="UsernameTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label>
        <asp:TextBox ID="PasswordTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="loginBtn" runat="server" Text="Login" OnClick="loginBtn_Click" />
        <asp:CheckBox ID="remembermeChkbx" runat="server" />
        <asp:Label ID="remembermeLbl" runat="server" Text="Remember me"></asp:Label>
        <br />
        <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
