<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Gridviewstudy.aspx.cs" Inherits="ASP.NetFramWork.Gridviewstudy" %>

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
                    <td> <asp:Label ID="lblId" runat="server" Text="ID"></asp:Label></td>
                    <td><asp:TextBox ID="IdTextBox" runat="server"></asp:TextBox></td>
               </tr>
        
         <tr>
             <td><asp:Label ID="lblName" runat="server" Text="Name"></asp:Label></td>
             <td><asp:TextBox ID="NameTextBox" runat="server"></asp:TextBox></td>
        </tr>
                 <tr>
             <td><asp:Label ID="lablCourse" runat="server" Text="Course"></asp:Label></td>
             <td><asp:TextBox ID="CourseTextBox" runat="server"></asp:TextBox></td>
        </tr>
                <tr>
                    <td> <asp:Button ID="btnsave" runat="server" Text="Save" OnClick="btnsave_Click" /> </td>
                </tr>
       
           </table>

        </div>

        <div>
            <asp:GridView ID="grdData" runat="server"></asp:GridView>
           
        </div>
    </form>
</body>
</html>
