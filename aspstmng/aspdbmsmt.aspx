<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="aspdbmsmt.aspx.cs" Inherits="aspstmng.aspdbmsmt" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 231px;
        }
        .auto-style5 {
            width: 151px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td>Student Id</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                    <td rowspan="4" class="auto-style4">
                        <asp:Image ID="Image1" runat="server" Height="114px" Width="222px" />
                    </td>
                </tr>
                <tr>
                    <td>Student name</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style3"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Student class</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>annual fees</td>
                    <td class="auto-style5">
                        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="3" >
                        <asp:Button ID="btnselect" runat="server" Text="select" CssClass="auto-style3" />
                        <asp:Button ID="btninsert" runat="server" Text="insert" />
                        <asp:Button ID="btnchoosefile" runat="server" Text="choosefile" />
                    </td>
                </tr>
                <tr>
                    <td colspan="3" >
                        <asp:Button ID="btnupdate" runat="server" Text="update" />
                        <asp:Button ID="btndelete" runat="server" Text="delete" />
                        <asp:Button ID="btnuploadimage" runat="server" Text="upload image" Width="350px" OnClick="btnuploadimage_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnresetall" runat="server" Text="Resetall" Width="679px" />
                    </td>
                    <td colspan="2" >&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
