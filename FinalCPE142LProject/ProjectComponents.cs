using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalCPE142LProject
{
    public partial class ProjectComponents : Component
    {
        public ProjectComponents()
        {
            InitializeComponent();
        }

        public ProjectComponents(IContainer container)
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

        class AdminAccount : UserAccount
        {
            private string role;
            public AdminAccount(string firstName, string lastName, string role, string userName, string pasword) : base(firstName, lastName, userName, pasword)
            {
                this.role = "Admin";
            }
            public override bool validateLogin(string userName, string password)
            {
                if (userName == "admin" && password == "admin123")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            public string getRole()
            {
                return role;
            }
        }/*
        class User : UserAccount
        {
            private string phone;
            
            public User(string firstName, string lastName, string phone, string userName, string password)
            {
                this.phone = phone;
            }

            public override bool validateLogin(string userName, string password)
            {
                if (userName && )
            }
            
        }
            */
    }
}
