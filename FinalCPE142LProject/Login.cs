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
        SqlConnection connection = new SqlConnection(@"Data Source=ASUS\SQLEXPRESS;Initial Catalog=dboExample;User ID=sa;Password=123;Encrypt=True;Trust Server Certificate=True");
        //AdminRole admin;
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

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(txtUser.Text) || String.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.Open();

                    try
                    {
                        string selectData = "SELECT * FROM tblAccounts WHERE username = @username AND password = @pass";
                        using (SqlCommand cmd = new SqlCommand(selectData, connection))
                        {
                            cmd.Parameters.AddWithValue("@username", txtUser.Text);
                            cmd.Parameters.AddWithValue("@pass", txtPass.Text);

                            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count >= 1)
                            {
                                this.Hide();
                                UserPage frmUser = new UserPage();
                                frmUser.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Incorrect username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }
        }

        private void btnCLose_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
