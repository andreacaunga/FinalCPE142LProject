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

namespace FinalCPE142LProject.Login_Signup
{
    public partial class Login : UserControl
    {
        public event EventHandler GoToSignup;
        //private readonly string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=dboExample;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True";

        Admin frmAdmin = new Admin();
        Main frmUser = new Main();
        Start frmStart = new Start();

        AdminAccount admin;
        public Login()
        {
            InitializeComponent();
        }

        private void lblLogin_Click(object sender, EventArgs e)
        {
            GoToSignup?.Invoke(this, EventArgs.Empty);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uName = txtUser.Text.Trim();
            string pass = txtPass.Text;

            // ADMIN LOGIN
            admin = new AdminAccount("Andrea", "Caunga", admin.getRole(), uName, pass);
            if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (!admin.validateLogin(uName,  pass))
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                frmStart.Hide();
                frmAdmin.ShowDialog();
                frmStart.Close();
            }
        }
    }
}
