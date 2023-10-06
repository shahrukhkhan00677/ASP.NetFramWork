using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace LinqStudy
{
    //LINQ = Language Integrated Query
    //LINQ two type => 1. Query Experision , 2. Function
    internal class EmployeeDetails
    {
        List<Employee> employees=new List<Employee>();
        int[] scores = {92,87,75,68,53 };
        public EmployeeDetails()
        {
            

            Department department1 = new Department();
            department1.Id = 1;
            department1.Name = "Account";
            department1.OfficeList.Add("Delhi");
            department1.OfficeList.Add("Noida");


            Department department2 = new Department();
            department2.Id = 2;
            department2.Name = "HR";
            department1.OfficeList.Add("Mumbai");
            department1.OfficeList.Add("Banglor");

            Employee objemp1 = new Employee();
            objemp1.Id = 1;
            objemp1.Name = "Shahrukh";
            objemp1.Salary = 10;
            objemp1.EmpDepartment= department1;
            employees.Add(objemp1);

            Employee objemp2 = new Employee();
            objemp2.Id = 2;
            objemp2.Name = "Ravi";
            objemp2.Salary = 20;
            objemp2.EmpDepartment = department2;

            employees.Add(objemp2);
        }
        public void GetScroreGraterthan80() 
        {
            #region WhereFunctionOfLinq

            // Query Experision.......

            /* IEnumerable<int> scoreQuery = from score in scores where score < 80 select score;
             foreach (int score in scoreQuery) 
             {
                 Console.WriteLine(score);
             }*/

            // through function ...........

            /*var result = scores.Where(x => x > 80);
            foreach (int score in result) 
            {
                Console.WriteLine(score);
            }*/

            /*var result1 = scores.Where(x => x < 50 || x>80);
            foreach(int score in result1)
            {
                Console.WriteLine(score);
            }*/

            /*  var listOfSearchedEmp = employees.Where(x => x.Name == "Shahrukh");
              foreach (Employee emp in listOfSearchedEmp)
              {
                  Console.WriteLine("searchedEmp : " + emp.Name);
              }*/

            /* var ListOfSearchEmpSalary = employees.Where(x => x.Salary > 10);
             foreach (var emp in ListOfSearchEmpSalary)
             {
                 Console.WriteLine("Emp : " +emp.Name);
             }*/
            #endregion

            #region SelectAndSelectMany

            // var listOfId=employees.Select(x => new { x.Id , x.Name });

           /* var listOfId = employees
                .Where(x=>x.Salary>10)
                .Select(x => new { x.Id, x.Name });

            foreach (var item in listOfId)
            {
                Console.WriteLine(item.Id);
                Console.WriteLine(item.Name);

            }*/

           /* var empDepartment = employees.Select(x => new { x.EmpDepartment });
            foreach (var item in empDepartment)
            {

                 Console.WriteLine("empDeparment : " + item.EmpDepartment.Name);
                foreach (var office in item.EmpDepartment.OfficeList)
                {

                    Console.WriteLine("OfficeName :"+ office);
                }
            }*/

           //select many  

            var newEmpDepartment=employees.SelectMany(x=> x.EmpDepartment.OfficeList);
            foreach (var item in newEmpDepartment)
            {
                Console.WriteLine(item);
            }

            #endregion
        }
    }
}
