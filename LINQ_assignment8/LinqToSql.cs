using System;
using System.Linq;
using System.Data.SqlClient;
using System.Data;

namespace LinqDemo
{
    public class LinqToSql
    {
        public static void Run()
        {
            string connectionString = "Server=MSCCS05;Database=studentDB;User Id=sa;Password=sql2024;";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT ID, Name, Age FROM Students";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable table = new DataTable();
                adapter.Fill(table);

                var students = from DataRow row in table.Rows
                               where Convert.ToInt32(row["Age"]) > 20
                               select new
                               {
                                   //ID = row["ID"],
                                   Name = row["Name"],
                                   Age = row["Age"]
                               };

                Console.WriteLine("Students older than 20:");
                foreach (var student in students)
                {
                    Console.WriteLine($"{student.ID}: {student.Name} - {student.Age} years old");
                }
                Console.WriteLine();
            }
        }
    }
}
