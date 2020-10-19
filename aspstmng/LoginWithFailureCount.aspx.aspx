<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginWithFailureCount.aspx.aspx.cs" Inherits="aspstmng.LoginWithFailureCount_aspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table align="center">
            <caption>Regestration Forms</caption>
            <tr>
                <td>user Name</td>
                <td>
                    <asp:TextBox ID="txtuser" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Passowrd</td>
                <td>
                    <asp:TextBox ID="txtpwd" runat="server" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnlgn" runat="server" Text="Login" OnClick="btnlgn_Click" />
                    <asp:Button ID="btnrst" runat="server" Text="Reset" OnClick="btnrst_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Label ID="lblmsg" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
