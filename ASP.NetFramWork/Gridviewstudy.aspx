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
            <asp:GridView ID="grdData" runat="server" AutoGenerateColumns="false" OnRowCommand="grdData_RowCommand" >
                <Columns>
                    <asp:TemplateField HeaderText="Id">
                        <ItemTemplate>
                            <asp:Label ID="lblid" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Id") %> ' > </asp:Label>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Name">
                        <ItemTemplate>
                            <asp:TextBox ID="txtname" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Name") %> ' > </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>

                    <asp:TemplateField HeaderText="Course">
                        <ItemTemplate>
                            <asp:TextBox ID="txtCourse" runat="server" Text='<%# DataBinder.Eval(Container.DataItem,"Course") %> ' > </asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                     <asp:TemplateField HeaderText="Edit">
                        <ItemTemplate>
                            <asp:Button ID="Editbtn" runat="server" Text="Edit" CommandName="Edit"
                                 CommandArgument='<%# DataBinder.Eval(Container.DataItem,"Id") %> ' />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>


            </asp:GridView>
            
            
        </div>
        <br />
        <br />
        <div> 
            <asp:Label ID="lbldays" runat="server" Text="DayName"></asp:Label>
            <asp:DropDownList ID="ddlWeekdays" runat="server" >
                <%--<asp:ListItem Text="select Day" Value="-1"></asp:ListItem>
                <asp:ListItem Text="Sunday"></asp:ListItem>
                <asp:ListItem Text="Monday"></asp:ListItem>
                <asp:ListItem Text="Tuesday"></asp:ListItem>
                <asp:ListItem Text="Wednesday"></asp:ListItem>
                <asp:ListItem Text="Thursday"></asp:ListItem>
                <asp:ListItem Text="Friday"></asp:ListItem>
                <asp:ListItem Text="Saturday"></asp:ListItem>--%>
            </asp:DropDownList>
            <asp:Button ID="btnselected" runat="server" Text="Selected" OnClick="btnselected_Click" />
        </div>
    </form>
</body>
</html>
