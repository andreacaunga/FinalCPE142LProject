using FinalCPE142LProject.Login_Signup;
using Microsoft.VisualBasic.Logging;
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
    public partial class Start : Form
    {
        Login login = new Login();
        Signup signup = new Signup();
        public Start()
        {
            InitializeComponent();
            addUserControl(login);

            login.GoToSignup += Login_GoToSignup;
            signup.GoToLogin += Signup_GoToLogin;
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainerStart.Controls.Clear();
            pnlContainerStart.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Login_GoToSignup(object sender, EventArgs e)
        {
            addUserControl(signup);
        }

        private void Signup_GoToLogin(object sender, EventArgs e)
        {
            addUserControl(login);
        }
    }
}
