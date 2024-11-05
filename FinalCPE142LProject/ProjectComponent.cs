using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCPE142LProject
{
    public partial class ProjectComponent : Component
    {
        public ProjectComponent()
        {
            InitializeComponent();
        }

        public ProjectComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }

    namespace UserAccountNamespace
    {
        abstract class UserAccount
        {
            private string firstName;
            private string lastName;
            protected string username;
            protected string pass;

            public UserAccount(string firstName, string lastName, string username, string pass)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.username = username;
                this.pass = pass;
            }
            public abstract bool validateLogin(string userName, string password);

            public string getFirstName()
            {
                return firstName;
            }
            public string getLastName()
            {
                return lastName;
            }
        }

        class AdminRole : UserAccount
        {
            private string role;
            public AdminRole(string firstName, string lastName, string role, string username, string pass) : base(firstName, lastName, username, pass)
            {
                this.role = role;
            }
            public override bool validateLogin(string username, string pass)
            {
                if (username == "admin" && pass == "admin123")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
