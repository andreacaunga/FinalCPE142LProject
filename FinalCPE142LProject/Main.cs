using FinalCPE142LProject.MainUserControl;
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
    public partial class Main : Form
    {
        Home home = new Home();
        Shop shop = new Shop();
        Cart cart = new Cart();
        UserInfo userInfo = new UserInfo();
        public Main()
        {
            InitializeComponent();
            addUserControl(home);
        }
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainerMain.Controls.Clear();
            pnlContainerMain.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            addUserControl(home);
        }

        private void btnShop_Click(object sender, EventArgs e)
        {
            addUserControl(shop);
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            addUserControl(cart);
        }

        private void btnMyAccount_Click(object sender, EventArgs e)
        {
            addUserControl(userInfo);
        }
    }
}
