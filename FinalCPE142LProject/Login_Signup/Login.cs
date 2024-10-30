//using FinalCPE142LProject.UserAccountNamespace;
using FinalCPE142LProject.UserAccountNamespace;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FinalCPE142LProject.Login_Signup
{
    public partial class Login : UserControl
    {
        //CHANGE CONNECTION STRING
        private string connectionString = "Data Source=ASUS\\SQLEXPRESS;Initial Catalog=dboExample;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True";
        public event EventHandler GoToSignup;
        private AdminAccount admin;
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

            if (string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(pass))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // ADMIN LOGIN
                admin = new AdminAccount("Andrea", "Caunga", "Admin", uName, pass);
                if (!admin.validateLogin(uName, pass))
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    Start frmStart = new Start();
                    Admin frmAdmin = new Admin();
                    frmStart.Hide();
                    frmAdmin.ShowDialog();
                    frmStart.Close();
                }

                // USER LOGIN
                SqlConnection connection = new SqlConnection(connectionString);
                string query = "SELECT * FROM [dboExample].[dbo].[tblUser] WHERE username=@username AND password=@password";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                connection.Open();

                if (reader.HasRows)
                {
                    Start frmStart = new Start();
                    Main frmMain = new Main();
                    frmStart.Hide();
                    frmMain.ShowDialog();
                    frmStart.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
