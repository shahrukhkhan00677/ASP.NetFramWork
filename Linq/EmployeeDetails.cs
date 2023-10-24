using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace LinqStudy
{
    //LINQ = Language Integrated Query
    //LINQ two type
    //1. Query Experision
    //2. Function
    internal class EmployeeDetails
    {
        List<Employee>employees=new List<Employee>();
        int[] scores = {92,87,75,68,53 };
        public EmployeeDetails()
        {
            #region Department 

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

            #endregion


            #region Employees

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

            Employee objemp3 = new Employee();
            objemp3.Id = 3;
            objemp3.Name = "Sagar";
            objemp3.Salary = 20;
            objemp3.EmpDepartment = department2;
            employees.Add(objemp3);

            Employee objemp4 = new Employee();
            objemp4.Id = 4;
            objemp4.Name = "Sagar kumar";
            objemp4.Salary = 10;
            objemp4.EmpDepartment = department2;
            employees.Add(objemp4);

            #endregion
        }
        public void GetScroreGraterthan80() 
        {
            #region WhereFunctionOfLinq

            //1. Query Experision....................................................

            /* IEnumerable<int> scoreQuery = from score in scores where score < 80 select score;
             foreach (int score in scoreQuery) 
             {
                 Console.WriteLine(score);
             }*/





            //2. Through function ......................................................

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

            /*var newEmpDepartment=employees.SelectMany(x=> x.EmpDepartment.OfficeList);
            foreach (var item in newEmpDepartment)
            {
                Console.WriteLine(item);
            }*/

            #endregion

            #region FirstAndDefault

            /* try
             {
                 var Emp = employees.First(x => x.Salary == 50);  // first name print of where salary = 20
                 Console.WriteLine(Emp.Name);
             }
             catch (Exception ex)
             {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.Message+" (not found data) ");


            }*/



            // **********************************************************************************************//



            /* try
             {
                 var Emp = employees.FirstOrDefault(x => x.Salary == 50);  // first name print of where salary = 20
                 if (Emp != null)
                 {
                     Console.WriteLine(Emp.Name);
                 }
                 else
                 {
                     Console.WriteLine("Record not found");
                 }
             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);
             }*/
            #endregion

            #region LastAndDefault
            /* try
             {
                 var emp = employees.LastOrDefault(x => x.Salary == 20);
                 if (emp != null)
                 {
                     Console.WriteLine(emp.Name);
                 }
                 else 
                 { Console.WriteLine("record not found");
                 }

             }
             catch (Exception ex)
             {
                 Console.WriteLine(ex.Message);


             }*/
            #endregion

            #region SingleAndDefault
            /* var emp=employees.SingleOrDefault(x => x.Salary == 20);
             if (emp!=null)
             {
                 Console.WriteLine(emp.Name);

             }
             else
             {
                 Console.WriteLine("Single record not have");
             }*/



            /*  try
              {
                  var emp = employees.SingleOrDefault(x => x.Salary == 20);
                  if (emp != null)
                  {
                      Console.WriteLine(emp.Name);

                  }

              }
              catch (Exception ex)
              {
                  Console.WriteLine(ex.Message);


              }*/


            #endregion

            #region AlAndlAny
            //any return bool value
            //any use to find the name start with letter (.....)


            /* var empName=employees.Any(x => x.Name.StartsWith("S"));
             Console.WriteLine(empName);*/

            //All are use to all employee name start "S" than value is true other wise value is false 

            /*   var empall=employees.All(x => x.Name.StartsWith("S"));
               Console.WriteLine(empall);*/
            #endregion

            #region ElementAtGroupBy
            // find through i
            /*var element=employees.ElementAt(0);
            Console.WriteLine(element.Name);*/

            #endregion

            #region GroupBy

            /*var empGroup= employees.GroupBy(x => x.Salary);

            foreach (var item in empGroup)
            {
                Console.WriteLine("item key "+item.Key);

                foreach (var emp in item)
                {

                    Console.WriteLine(emp.Name);
                    Console.WriteLine(emp.Salary);

                }
            }
*/

            #endregion

            #region Distinct
            

            #endregion
        }
    }
}
