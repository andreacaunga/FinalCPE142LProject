using FinalCPE142LProject.Models;
using FinalCPE142LProject.Repositories;
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
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
            this.DialogResult = DialogResult.Cancel;
        }

        int userID = 0;
        public void editUser(User user)
        {
            this.Text = "Edit User";

            this.txtUserID.Text = Convert.ToString(user.userID);
            this.txtfName.Text = user.fName;
            this.txtlName.Text = user.lName;
            this.txtUser.Text = user.username;
            this.txtAddress.Text = user.address;
            this.txtPhone.Text = user.phone;
            this.txtPass.Text = user.pass;

            this.userID = user.userID;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            User user = new User();

            user.userID = this.userID;
            user.fName = this.txtfName.Text;
            user.lName = this.txtlName.Text;
            user.username = this.txtUser.Text;
            user.address = this.txtAddress.Text;
            user.phone = this.txtPhone.Text;
            user.pass = this.txtPass.Text;

            var userRepo = new UserRepository();

            if (this.userID == 0)
            {
                userRepo.createUser(user);
            }
            else
            {
                userRepo.updateUser(user);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
