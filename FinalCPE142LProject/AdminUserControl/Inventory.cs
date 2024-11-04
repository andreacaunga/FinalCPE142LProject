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
//using Microsoft.Data.SqlClient;

namespace FinalCPE142LProject.AdminUserControl
{
    public partial class Inventory : UserControl
    {
        public Inventory()
        {
            InitializeComponent();
            ReadProducts();
        }

        public void ReadProducts()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Product ID");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Product name");
            dataTable.Columns.Add("Category");
            dataTable.Columns.Add("Price");

            var productRepo = new ProductRepository();
            var products = productRepo.ReadProducts();

            foreach (var product in products)
            {
                var row = dataTable.NewRow();

                row["Product ID"] = product.productID;
                row["Quantity"] = product.quantity;
                row["Product name"] = product.productName;
                row["Category"] = product.category;
                row["Price"] = product.itemPrice;

                dataTable.Rows.Add(row);
            }
            // ADDED this.
            this.dgvInventory.DataSource = dataTable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CreateProduct frmCreate = new CreateProduct();
            if (frmCreate.ShowDialog() == DialogResult.Cancel) return;

            ReadProducts();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var val = this.dgvInventory.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int productID = Convert.ToInt32(val);

            var productRepo = new ProductRepository();
            var product = productRepo.ReadProduct(productID);

            if (product == null) return;

            CreateProduct frmCreateProduct = new CreateProduct();
            frmCreateProduct.updateProduct(product);

            if (frmCreateProduct.ShowDialog() == DialogResult.OK)
            {
                ReadProducts();
            }
        }
        private void btnRemove_Click(object sender, EventArgs e)
        {
            var val = this.dgvInventory.SelectedRows[0].Cells[0].Value.ToString();

            if (val == null || val.Length == 0) return;

            int productID = Convert.ToInt32(val);

            var productRepo = new ProductRepository();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove this product?", "Remove Product", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            productRepo.deleteProduct(productID);

            ReadProducts();
        }
    }
}
