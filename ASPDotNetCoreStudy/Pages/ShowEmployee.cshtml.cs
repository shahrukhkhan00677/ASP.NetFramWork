using ASPDotNetCoreStudy.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;



namespace ASPDotNetCoreStudy.Pages
{
    public class ShowEmployeeModel : PageModel
    {
        public List<Employee> Employees = new List<Employee>();
        public AppDBContext appDbContext { get; set; }
        public void OnGet()
        {
            CreateData();

        }
        public void CreateData()
        {
            Employees= appDbContext.Employees.ToList();
            /*Employee obj1=new Employee();
            obj1.Name = "Shahrukh";
            obj1.Age = 20;
            obj1.Salary = 100;
            Employees.Add(obj1);


            Employee obj2 = new Employee();
            obj2.Name = "Ravi";
            obj2.Age = 30;
            obj2.Salary = 200;
            Employees.Add(obj2);*/
        }

        public ShowEmployeeModel(AppDBContext data)
        {
            appDbContext=data;
        }
    }
}
