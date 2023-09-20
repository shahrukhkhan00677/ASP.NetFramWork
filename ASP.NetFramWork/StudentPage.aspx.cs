using DataAccessLayerStudy.Model;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Collections.Specialized.BitVector32;

namespace ASP.NetFramWork
{
    // the data is HTTP protocol 
    // HTTPS -- this protocol is state less
    //State management -
    //1.Client Side state management
    //a.ViewState
    //b.Hiddenfields
    //c.Cookies
    //d.ControlState 
    //e.QueryString

    //2.Server Side state management---
    //a.Session state
    //b.Application state
    //c.cache
    //d.Profile

    //life cycle of ASP.net
    //1.user request a page of browser
    //2.starting of page life cycle (request and response) isPostBack property
    //3.page initilization ( given unike ID)
    //4.page load (page load on client side)
    //5. page validation (control check)
    //6.post back event handling 
    //7. page rendering ( full page load on Browser)
    //8. page unload

    //H.w
    public partial class StudentPage : System.Web.UI.Page
        
    {
        int id;
        public StudentPage()
        {
          id = 12;

        }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (ViewState["I"] != null)
                {
                    id = Convert.ToInt32(ViewState["I"]);
                }
                HiddenField1.Value = Convert.ToString(id);
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id = 0;
           //int a = 10 / id;
            ViewState["I"] = id;
            Session["ID"] = id;
            Cache["ID"] = id;
            string name =txtName.Text;
            string Id= txtId.Text;
            string Course= txtCourse.Text;
            
            Student objStudent=new Student();
            if (!string.IsNullOrEmpty(Id))
            objStudent.Id = Convert.ToInt32(Id);
            objStudent.Name = name;
            objStudent.Course = Course;

            Response.Cookies["cookieCourse"].Value = Course;

           // Response.Redirect("ViewStudentDetails.aspx?User="+name);
        }
        
    }
}