using FinalCPE142LProject.Repositories;
using FinalCPE142LProject.UserAccountNamespace;
using Microsoft.Data.SqlClient;
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
    public partial class Login : Form
    {
        // CHANGE CONNECTION STRING
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=dboProject;Persist Security Info=True;User ID=sa;Password=123;Trust Server Certificate=True");
        AdminRole admin;
        public Login()
        {
            InitializeComponent();
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            Signup frmSignup = new Signup();
            this.Hide();
            frmSignup.ShowDialog();
            //this.Close();
            //this.Hide();
        }

        private void chkboxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chkboxShowPass.Checked)
            {
                txtPass.PasswordChar = '\0';
            }
            else
            {
                txtPass.PasswordChar = '•';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUser.Text.Trim();
            string pass = txtPass.Text.Trim();

            admin = new AdminRole("Andrea", "Caunga", "admin", username, pass);
            // Input validation for empty fields
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate user credentials
            var userRepo = new UserRepository();
            bool isValidUser = userRepo.validateUser(username, pass);

            if (admin.validateLogin(username, pass))
            {
                this.Hide();
                AdminPage frmAdmin = new AdminPage();
                frmAdmin.ShowDialog();
                this.Close();
            }
            else if (isValidUser)
            {
                this.Hide();
                UserPage frmUser = new UserPage();
                frmUser.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
