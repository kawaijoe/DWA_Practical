<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="dwa_s1234567.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>NP Book Rental</title>
</head>
<body>
    <form id="form1" runat="server" style="font-family: Arial, Helvetica, sans-serif">
    <div>
        <table style="border: 1px solid #000000; margin: auto; width: auto">
            <tr>
                <td style="vertical-align: top; width: 50%;">
                    <asp:Image ID="imgNPLogo" runat="server" ImageUrl="~/Images/nplogo.gif" />
                </td>
                <td style="width: 50%">Login ID:<br />
                    <asp:TextBox ID="txtLoginID" runat="server" BackColor="#FFFFCC" TextMode="Email" ToolTip="e-mail address"></asp:TextBox>
                    <br />
                    Password:<br />
                    <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" BackColor="#FFFFCC"></asp:TextBox>
                    <br />
                    <asp:RadioButton ID="rdoStaff" runat="server" Checked="True" GroupName="Users" Text="Staff" />
                    <asp:RadioButton ID="rdoCustomer" runat="server" GroupName="Users" Text="Customer" />
                    <br />
                    <asp:Button ID="btnLogin" runat="server" Text="Login" BackColor="#3399FF" Font-Bold="True" ForeColor="White" Height="30px" Width="80px" OnClick="btnLogin_Click" />
&nbsp;<asp:Label ID="lblMessage" runat="server" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Image ID="imgLogo" runat="server" ImageUrl="~/Images/logo.jpg" />
                    <br />
                    Practical exercises for DWA (Developing Web Applications) module.</td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
