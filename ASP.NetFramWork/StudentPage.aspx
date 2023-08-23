<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentPage.aspx.cs" Inherits="ASP.NetFramWork.StudentPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><asp:Label ID="lblName" runat="server" Text="Username"></asp:Label> </td>
                    <td><asp:TextBox ID="txtName" runat="server"></asp:TextBox></td>
                </tr>

                 <tr>
                    <td><asp:Label ID="LblId" runat="server" Text="Id"></asp:Label> </td>
                    <td><asp:TextBox ID="txtId" runat="server"></asp:TextBox></td>
                </tr>

                 <tr>
                    <td><asp:Label ID="LblCourse" runat="server" Text="Course"></asp:Label> </td>
                    <td><asp:TextBox ID="txtCourse" runat="server"></asp:TextBox></td>
                </tr>

                
            </table>

        </div>
        <asp:Button ID="Button1" runat="server" BackColor="YellowGreen" BorderColor="Black" Text="Save" OnClick="Button1_Click" />
    </form>
</body>
</html>
