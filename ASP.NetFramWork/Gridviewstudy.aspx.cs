using DataAccessLayerStudy.Model;
using DataAccessLayerStudy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.NetFramWork
{ //h.w drop down in the gridview 
    public partial class Gridviewstudy : System.Web.UI.Page
    {
            List<Student> lststudent = new List<Student>();

            List<string> weekday = new List<string>();   
        protected void Page_Load(object sender, EventArgs e)
        {
            weekday.Add("Sunday");
            weekday.Add("Monday");
            weekday.Add("Tuesday");
            weekday.Add("Wednesday");
            weekday.Add("Thursday");
            weekday.Add("Friday");
            weekday.Add("Saturday");

            ddlWeekdays.DataSource = weekday;
            ddlWeekdays.DataBind();
             

;

            Student student1 = new Student();
            student1.Id = 1;
            student1.Name = "Shahrukh";
            student1.Course = "DotNet";
            lststudent.Add(student1);


            Student student2 = new Student();
            student2.Id = 2;
            student2.Name = "Ravi";
            student2.Course = "DotNet";
            lststudent.Add(student2);


            Student student3 = new Student();
            student3.Id = 3;
            student3.Name = "Ekram";
            student3.Course = "DotNet";

            lststudent.Add(student3);

           

            grdData.DataSource = lststudent;
            grdData.DataBind();

        }
        protected void btnsave_Click(object sender, EventArgs e)
        {
           DataContext dataContext = new DataContext();
            dataContext.GetStudentData();

            /*
            Student student1 = new Student();
            student1.Id = Convert.ToInt32(IdTextBox.Text);
            student1.Name =NameTextBox.Text;
            student1.Course = CourseTextBox.Text;
            if (ViewState["StudentData"]!=null)
            {
                lststudent = (List<Student>)ViewState["StudentData"];
                lststudent.Add(student1);

            }
            else
            {
                lststudent.Add(student1 );
            }



            ViewState["StudentData"] = lststudent;
            grdData.DataSource = lststudent;
            grdData.DataBind();*/

        }

        

        protected void btnselected_Click(object sender, EventArgs e)
        {
            string value=ddlWeekdays.SelectedValue;
        }
    }
}