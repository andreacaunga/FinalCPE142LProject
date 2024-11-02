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
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=dboExample;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True");
        public Login()
        {
            InitializeComponent();
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            Signup frmSignup = new Signup();
            this.Hide();
            frmSignup.ShowDialog();
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

        private void btnSignup_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    try
                    {
                        connection.Open();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Error: " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }
    }
}
