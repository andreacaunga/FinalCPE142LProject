namespace FinalCPE142LProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void lblSignup_Click(object sender, EventArgs e)
        {
            Signup frmSignup = new Signup();
            frmSignup.Show();
            this.Hide();
        }
    }
}
