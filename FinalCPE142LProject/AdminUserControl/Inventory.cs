using FinalCPE142LProject.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalCPE142LProject.AdminUserControl
{
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
            ReadItems();
        }
        public void ReadItems()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Item ID");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Item name");
            dataTable.Columns.Add("Price");

            var repo = new ItemRepository();
            var items = repo.ReadItems();

            // TEST
            if (items == null || items.Count == 0)
            {
                MessageBox.Show("No items retrieved from the database.");
                return; // Exit if no items found
            }

            foreach (var item in items)
            {
                var row = dataTable.NewRow();

                row["Item ID"] = item.itemID;
                row["Category"] = item.itemCategory;
                row["Quantity"] = item.itemQuantity;
                row["Item name"] = item.itemName;
                row["Price"] = item.itemPrice;

                dataTable.Rows.Add(row);
            }
            this.dgvInventory.DataSource = dataTable;
        }
    }
}
