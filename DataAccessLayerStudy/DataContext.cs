using Npgsql;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerStudy
{
    public class DataContext
    {

        string ConnectionString = "Server=localhost;Database=NewDB;User Id=postgres;Password=Khan8477";
        public void GetStudentData()
        {
            //SqlConnection con = new SqlConnection(ConnectionString);
            NpgsqlConnection con= new NpgsqlConnection(ConnectionString);
            
           // SqlCommand cmd = new SqlCommand("Select * from student", con);
           NpgsqlCommand cmd = new NpgsqlCommand("Select * from student", con);

            con.Open();
            // SqlDataReader sqlDataReader = cmd.ExecuteReader();

            var sqldatareader = cmd.ExecuteReader();
            while (sqldatareader.Read())
            {

            }

            con.Close();
        }
    }
}
