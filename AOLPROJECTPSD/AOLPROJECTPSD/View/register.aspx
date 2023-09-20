<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="AOLPROJECTPSD.View.register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="registerLbl" runat="server" Text="REGISTER"></asp:Label>
        <br />
        <asp:Label ID="usernameLbl" runat="server" Text="Username = "></asp:Label>
        <asp:TextBox ID="usernameTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="Role = "></asp:Label>
        <asp:RadioButton ID="admin_radiobutton" runat="server" Text="Admin" GroupName="role" />
        <asp:RadioButton ID="seller_radiobutton" runat="server" Text="Seller" GroupName="role"/>
        <asp:RadioButton ID="buyer_radiobutton" runat="server" Text="Buyer" GroupName="role"/>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Gender  = "></asp:Label>
        <asp:RadioButton ID="female_radiobutton" runat="server" Text ="Female" GroupName ="Gender"/>
        <asp:RadioButton ID="male_radiobutton" runat="server" Text ="Male" GroupName ="Gender"/>
        <br />
        <asp:Label ID="emailLbl" runat="server" Text="Email = "></asp:Label>
        <asp:TextBox ID="emailTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="passwordLbl" runat="server" Text="Password         = "></asp:Label>
        <asp:TextBox ID="passwordTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="confirmpasswordLbl" runat="server" Text="Confirm Password  = "></asp:Label>
        <asp:TextBox ID="confirmpasswordTxt" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="registerBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" />
        <asp:Label ID="errorLbl" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>
