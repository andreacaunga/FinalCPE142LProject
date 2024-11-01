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

        public Login()
        {
            InitializeComponent();
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            GoToSignup?.Invoke(this, EventArgs.Empty);
        }
    }
}
