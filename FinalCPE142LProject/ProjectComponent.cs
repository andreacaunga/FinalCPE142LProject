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
            protected string userName;
            protected string password;

            public UserAccount(string firstName, string lastName, string userName, string password)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.userName = userName;
                this.password = password;
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
            public AdminRole(string firstName, string lastName, string role, string userName, string password) : base(firstName, lastName, userName, password)
            {
                this.role = role;
            }
            public override bool validateLogin(string userName, string password)
            {
                return this.userName == "admin" && this.password =="admin123";
            }
            public string getRole()
            {
                return role;
            }
        }
    }
}
