<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ASP.NetFramWork.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
  <style>
        #username{background:yellow; }
        #email{background:yellow;}  
        h3{color:green}
        button{
            background:radial-gradient(skyblue,blue); border:3px solid black;color:white;font-size:20px;font-weight:bold;
            border-radius:10px
        }
        #btn{margin-left:80px}
        
    </style> 
</head>
<body>
    <form id="form1" runat="server">
      <!--  <div>
            <h1>Login Form </h1>
            <input type="text" name="name" value="" placeholder="Enter username" id="username" /> <br /> <br />
            <input type="password" name="name" value="" placeholder="Enter password" id="username" /> <br /> <br />
            <input type="email" name="name" value="" placeholder="Enter your Email" id="email"/> <br /><br />
            <h3>Date Of Birth</h3> 
            <input type="date" name="name" value="" min="1995-01-01"/>
            <h3 >Course :</h3>
            <input type="checkbox" name="name" value=""/>DotNet 
            <input type="checkbox" name="name" value=""/>Java
            <input type="checkbox" name="name" value=""/>Python
            <input type="checkbox" name="name" value=""/>Digital Markiting
            <input type="checkbox" name="name" value=""/>C++
            <input type="checkbox" name="name" value=""/>Full Stack
            <input type="checkbox" name="name" value=""/>Data Analytic
            <h3>Branch</h3>
            <select>
                <option value="value" selected disabled>Branch</option>
                <option value="value">Sec-16</option>
                <option value="value">Sec-63</option>
                <option value="value">Pitampura</option>
                <option value="value">Gurgon</option>

            </select>
            <h3>Gender :</h3>
            <input type="radio" name="gender" value="Male"/>Male 
            <input type="radio" name="gender" value="Female"/>Female
            <br/><br/>
            <button>Submit</button>
            
            
        </div> -->

        <!-- ///////////////////////////////////////////////////////////////////////////////////////////////////// -->

        <div>
            <h1>Login Form </h1>
            <table>
                <tr>
                    <td>
                        <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label></td>

                    <td><asp:TextBox ID="textUserName" runat="server"></asp:TextBox>

                        </td>
                </tr>
                <tr>
                    <td>Password :</td>
                    <td><input type="password" name="name" value="" placeholder="Enter password" id="username" /></td>
                </tr>
                <tr> 
                    <td>Email :</td>
                    <td><input type="email" name="name" value="" placeholder="Enter your Email" id="email"/></td>
                </tr>

                 <tr> 
                    <td>D.O.B :</td>
                    <td><input type="date" name="name" value="" min="1995-01-01"/></td>
                </tr>

                  <tr> 
                    <td>Course :</td>
                    <td><input type="checkbox" name="name" value=""/>DotNet 
                    <input type="checkbox" name="name" value=""/>Java
                    <input type="checkbox" name="name" value=""/>Python
                    <input type="checkbox" name="name" value=""/>Digital Markiting
                    <input type="checkbox" name="name" value=""/>C++
                    <input type="checkbox" name="name" value=""/>Full Stack
                    <input type="checkbox" name="name" value=""/>Data Analytic</td>
                </tr>

                <tr> 
                    <td>Branch :</td>
                    <td>  
                <select>

                <option value="value" selected disabled>Branch</option>
                <option value="value">Sec-16</option>
                <option value="value">Sec-63</option>
                <option value="value">Pitampura</option>
                <option value="value">Gurgon</option>

               </select>

                    </td>
                </tr>

                 <tr> 
                    <td>Gender</td>
                    <td> 
                         <input type="radio" name="gender" value="Male"/>Male 
                         <input type="radio" name="gender" value="Female"/>Female
                         <input type="radio" name="gender" value="Othere"/>Other

                    </td>
                </tr>
            </table>
            <br />
            <table>
                <tr>
                    <td colspan="2">
                        <button id="btn">Submit</button>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
