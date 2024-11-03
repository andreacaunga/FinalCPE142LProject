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
        // CHANGE THIS
        private readonly string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=dboExample;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True";

        public List<User> ReadUsers()
        {
            var users = new List<User>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM tblAccounts";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                user.userID = reader.GetInt32(0);
                                user.fName = reader.GetString(1);
                                user.lName = reader.GetString(2);
                                user.username = reader.GetString(3);
                                user.address = reader.GetString(4);
                                user.phone = reader.GetString(5);
                                user.pass = reader.GetString(6);

                                users.Add(user);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return users;
        }

        public User? ReadUser(int userID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * FROM tblAccounts WHERE user_id = @userID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userID", userID);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                User user = new User();
                                user.userID = reader.GetInt32(0);
                                user.fName = reader.GetString(1);
                                user.lName = reader.GetString(2);
                                user.username = reader.GetString(3);
                                user.address = reader.GetString(4);
                                user.phone = reader.GetString(5);
                                user.pass = reader.GetString(6);

                                return user;    
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return null;
        }

        public void createUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO tblAccounts" +
                        " (first_name, last_name, username, address, phone, password) VALUES " +
                        "(@fName, @lName, @username, @address, @phone, @pass)";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@fName", user.fName);
                        cmd.Parameters.AddWithValue("@lName", user.lName);
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@address", user.address);
                        cmd.Parameters.AddWithValue("@phone", user.phone);
                        cmd.Parameters.AddWithValue("@pass", user.pass);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void updateUser(User user)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE tblAccounts SET " +
                        "first_name = @fName, last_name = @lName, username = @username, address = @address, phone = @phone, password = @pass " +
                        "WHERE user_id = @userID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@fName", user.fName);
                        cmd.Parameters.AddWithValue("@lName", user.lName);
                        cmd.Parameters.AddWithValue("@username", user.username);
                        cmd.Parameters.AddWithValue("@address", user.address);
                        cmd.Parameters.AddWithValue("@phone", user.phone);
                        cmd.Parameters.AddWithValue("@pass", user.pass);
                        cmd.Parameters.AddWithValue("@userID", user.userID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);  
            }
        }

        public void deleteUser(int userID)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "DELETE FROM tblAccounts " +
                        "WHERE user_id = @userID";

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@userID", userID);

                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
