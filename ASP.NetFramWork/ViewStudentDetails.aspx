<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ViewStudentDetails.aspx.cs" Inherits="ASP.NetFramWork.ViewStudentDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <br />
            <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="UserTextBox" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
