using FinalCPE142LProject.AdminUserControl;
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

namespace FinalCPE142LProject
{
    public partial class Admin : Form
    {
        AdminDashboard dashboard = new AdminDashboard();
        UserAccounts accounts = new UserAccounts();
        Inventory inventory = new Inventory();
        Transactions transactions = new Transactions();

        public Admin()
        {
            InitializeComponent();

            addUserControl(dashboard);
            //ReadUsers();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainerAdmin.Controls.Clear();
            pnlContainerAdmin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            addUserControl(dashboard);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            addUserControl(accounts);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            addUserControl(inventory);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            addUserControl(transactions);
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start start = new Start();
            start.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        /*
        public void ReadUsers()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("User ID");
            dataTable.Columns.Add("First name");
            dataTable.Columns.Add("Last name");
            dataTable.Columns.Add("Username");

            var repo = new UserRepository();
            var users = repo.ReadUsers();

            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["User ID"] = user.id;
                row["First name"] = user.firstName;
                row["Last name"] = user.lastName;
                row["Username"] = user.userName;

                dataTable.Rows.Add(row);
            }
            this.dgvUser.DataSource = dataTable;
        }
        */
    }
}
