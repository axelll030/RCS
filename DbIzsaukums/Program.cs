using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbIzsaukums
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlReader();
            EntityFramework();

            Console.Read();
        }

        static void EntityFramework()
        {
            List<Users> users = new List<Users>();
            using (var db = new DB())
            {
                 users = db.Users.OrderBy(u => u.LastName).ToList();
            }

            foreach (Users user in users)
            {
                Console.WriteLine("Id: {0}, vards: {1} {2}  ", user.Id, user.FirstName, user.LastName);
            }
        }

        static void SqlReader()
        {
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\JEVG\Documents\DB.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();

            string query = "SELECT * FROM Users ORDER BY LastName";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();

            List<Users> users = new List<Users>();
            while (reader.Read())
            {
                //object id = reader["Id"];
                //int id = Convert.ToInt32(reader["Id"]);
                //int id = int.Parse(reader["Id"].ToString());
                //string firstName = Convert.ToString(reader["FirstName"]);
                //string lastName = Convert.ToString(reader["LastName"]);

                users.Add(new Users()
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    FirstName = Convert.ToString(reader["FirstName"]),
                    LastName = Convert.ToString(reader["LastName"]),
                });
            }

            reader.Close();
            conn.Close();

            Console.WriteLine("Lietotaji: ");
            foreach (Users user in users)
            { 
                Console.WriteLine("Id: {0}, vards: {1} {2}  ", user.Id, user.FirstName, user.LastName);
            }
        }
    }
}
