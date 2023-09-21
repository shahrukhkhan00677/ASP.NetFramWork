using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerStudy.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Course { get; set; }

        public Student(int id , string name , string course)
        {
            this.Id = id;
            this.Name = name;
            this.Course = course;
        }
        public Student()
        {
            
        }

    }
}
