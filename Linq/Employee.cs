using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqStudy
{
    internal class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public Department EmpDepartment { get; set; }
    }
    internal class Department 
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<string> OfficeList = new List<string>();
        
    }
}
