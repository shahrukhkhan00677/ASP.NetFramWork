using ASP.NetFramWork.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NetFramWork
{
    public partial class StudentPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name =txtName.Text;
            string Id= txtId.Text;
            string Course= txtCourse.Text;
            
            Student objStudent=new Student();
            objStudent.Id = Convert.ToInt32(Id);
            objStudent.Name = name;
            objStudent.Course = Course;
        }
        
    }
}