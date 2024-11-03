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
    public partial class UserAccounts : UserControl
    {
        public UserAccounts()
        {
            InitializeComponent();
            ReadUsers();
        }

        public void ReadUsers()
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("User ID");
            dataTable.Columns.Add("First name");
            dataTable.Columns.Add("Last name");
            dataTable.Columns.Add("Username");
            dataTable.Columns.Add("Address");
            dataTable.Columns.Add("Phone number");
            dataTable.Columns.Add("Password");

            var userRepo = new UserRepository();
            var users = userRepo.ReadUsers();

            foreach (var user in users)
            {
                var row = dataTable.NewRow();

                row["User ID"] = user.userID;
                row["First name"] = user.fName;
                row["Last name"] = user.lName;
                row["Username"] = user.username;
                row["Address"] = user.address;
                row["Phone number"] = user.phone;
                row["Password"] = user.pass;

                dataTable.Rows.Add(row);
            }
            this.dgvUser.DataSource = dataTable;
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            CreateUser frmCreate = new CreateUser();
            if (frmCreate.ShowDialog() == DialogResult.Cancel) return;

            ReadUsers();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var val = this.dgvUser.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int userID = Convert.ToInt32(val);

            var userRepo = new UserRepository();
            var user = userRepo.ReadUser(userID);

            if (user == null) return;

            CreateUser frmCreateUser = new CreateUser();
            frmCreateUser.editUser(user);

            if (frmCreateUser.ShowDialog() == DialogResult.OK)
            {
                ReadUsers();
            }
        }

        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            var val = this.dgvUser.SelectedRows[0].Cells[0].Value.ToString();

            if (val == null || val.Length == 0) return;

            int userID = Convert.ToInt32(val);

            var userRepo = new UserRepository();

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this user?", "Delete User", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.No) return;

            userRepo.deleteUser(userID);

            ReadUsers();
        }
    }
}
