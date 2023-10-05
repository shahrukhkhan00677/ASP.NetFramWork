using DataAccessLayerStudy.Model;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerStudy
{
    public class DataContext
    {

        string ConnectionString = "Server=DESKTOP-JUAIM1M\\SQLEXPRESS;Database=Code;Integrated Security=true";
        public List<Student> GetStudentData()
        {
            var studentData= new List<Student>();
            SqlConnection con = new SqlConnection(ConnectionString);
           // NpgsqlConnection con= new NpgsqlConnection(ConnectionString);
            
            SqlCommand cmd = new SqlCommand("Select * from Students", con);
          // NpgsqlCommand cmd = new NpgsqlCommand("Select * from student", con);

            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

           // var sqldatareader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                int id = (int)sqlDataReader["Id"];
                string name =(string) sqlDataReader["Name"];
                string course = (string)sqlDataReader["Course"];

                var objStudent = new Student(id, name, course);
                studentData.Add(objStudent);
            }

            con.Close();
            return studentData;
        }
        public void SaveStudentData(Student objStudent)
        {
            SqlConnection con = new SqlConnection(ConnectionString);
            SqlCommand cmd = new SqlCommand($"insert into Students values('{objStudent.Name}','{objStudent.Course}') ", con);
            try
            {
                con.Open();
                cmd.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {

            }
            finally 
            { 
                con.Close();
            }

        }
        public List<Student> GetDataFromSp()
        {
            var studentData = new List<Student>();
            SqlConnection con = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "myproc";

            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            while (sqlDataReader.Read())
            {
                int id = (int)sqlDataReader["Id"];
                string name = (string)sqlDataReader["Name"];
                string course = (string)sqlDataReader["Course"];

                var objStudent = new Student(id, name, course);
                studentData.Add(objStudent);
            }

            con.Close();
            return studentData;
        }


        public Student GetSingleStudentData(int id )
        {
            var objStudent = new Student();
            SqlConnection con = new SqlConnection(ConnectionString);

            SqlCommand cmd = new SqlCommand($"Select * from Students where id={id}", con); //string interpolation $

            con.Open();
            SqlDataReader sqlDataReader = cmd.ExecuteReader();

            sqlDataReader.Read();
            
                objStudent.Id = (int)sqlDataReader["Id"];
            objStudent.Name = (string)sqlDataReader["Name"];
            objStudent.Course = (string)sqlDataReader["Course"];

            con.Close();
            return objStudent;

        }
    }


    }

