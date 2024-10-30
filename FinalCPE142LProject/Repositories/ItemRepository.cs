using FinalCPE142LProject.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCPE142LProject.Repositories
{
    public class ItemRepository
    {
        private readonly string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=dboExample;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True";

        public List<Item> ReadItems()
        {
            var items = new List<Item>();

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT * [dboExample].[dbo].[tblItem2]";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Item item = new Item();
                                item.itemID = reader.GetInt32(0);
                                item.itemCategory = reader.GetString(1);
                                item.itemQuantity = reader.GetInt32(2);
                                item.itemName = reader.GetString(3);
                                item.itemPrice = reader.GetFloat(4);

                                items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            return items;
        }
        public void createItem(Item item)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "INSERT INTO [dboExample].[dbo].[tblItem2]" +
                            " (item_category, quantity, item_name, item_price) VALUES " +
                            "(@item_category, @quantity, @item_name, @item_price)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@item_category", item.itemCategory);
                        command.Parameters.AddWithValue("@quantity", item.itemQuantity);
                        command.Parameters.AddWithValue("@item_name", item.itemName);
                        command.Parameters.AddWithValue("@item_price", item.itemPrice);

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
