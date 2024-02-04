using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIgnInSignUpApp
{
    internal class User
    {
        public string userName;
        public string password;
        public string role;
        public User() { }
        public User(string userName, string password, string role)
        {
            this.userName=userName;
            this.password=password;
            this.role=role;
        }
        public User(User user)
        {
            this.userName=user.userName;
            this.password=user.password;
            this.role = user.role;
        }
    }
}
