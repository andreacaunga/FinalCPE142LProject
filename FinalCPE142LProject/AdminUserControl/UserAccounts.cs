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
    }
}
