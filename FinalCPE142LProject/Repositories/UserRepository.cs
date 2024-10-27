using FinalCPE142LProject.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCPE142LProject.Repositories
{
    public class UserRepository
    {
        private readonly string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=dboExample;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True";

        public List<User> ReadUsers()
        {
            var users = new List<User>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // change this
                    string query = "SELECT * FROM [dboExample].[dbo].[tblUser]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                user.id = reader.GetInt32(0);
                                user.firstName = reader.GetString(1);
                                user.lastName = reader.GetString(2);
                                user.userName = reader.GetString(3);
                                user.pass = reader.GetString(4);

                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return users;
        }

        public void createUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [dboExample].[dbo].[tblUser]" + 
                            " (first_name, last_name, username, password) VALUES " +
                            "(@first_name, @last_name, @username, @password)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@first_name", user.firstName);
                        command.Parameters.AddWithValue("@last_name", user.lastName);
                        command.Parameters.AddWithValue("@username", user.userName);
                        command.Parameters.AddWithValue("@password", user.pass);

                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.Write(ex.ToString());
            }
        }
    }
}
