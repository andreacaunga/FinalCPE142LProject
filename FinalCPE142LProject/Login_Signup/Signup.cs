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
    public partial class Signup : UserControl
    {
        public event EventHandler GoToLogin;
        public Signup()
        {
            InitializeComponent();
        }

        private void lblLogin_Click_1(object sender, EventArgs e)
        {
            GoToLogin?.Invoke(this, EventArgs.Empty);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string fName = txtFname.Text.Trim();
            string lName = txtLname.Text.Trim();
            string uName = txtUser.Text.Trim();
            string phone = txtPhone.Text.Trim();
            string pass = txtPass.Text;
            string conPass = txtPass.Text;

            if (string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName) || string.IsNullOrEmpty(uName) || string.IsNullOrEmpty(phone)
                || string.IsNullOrEmpty(pass) || string.IsNullOrEmpty(conPass))
            {
                MessageBox.Show("All fields are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void Signup_Load(object sender, EventArgs e)
        {

        }
    }
}
