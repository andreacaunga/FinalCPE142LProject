﻿using FinalCPE142LProject.AdminUserControl;
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
    public partial class AdminPage : Form
    {
        AdminDashboard dashboard = new AdminDashboard();
        UserAccounts accounts = new UserAccounts();
        Inventory inventory = new Inventory();
        Transactions transactions = new Transactions();

        public AdminPage()
        {
            InitializeComponent();

            addUserControl(dashboard);
            //ReadUsers();
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainerAdmin.Controls.Clear();
            pnlContainerAdmin.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            addUserControl(dashboard);
        }

        private void btnAccounts_Click(object sender, EventArgs e)
        {
            addUserControl(accounts);
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            addUserControl(inventory);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            addUserControl(transactions);
        }

        private void btnSignout_Click(object sender, EventArgs e)
        {
            Login frmLogin = new Login();
            this.Close();
            frmLogin.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

       
    }
}
