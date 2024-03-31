using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInSignUp.BL
{
    internal class USER
    {
        private string UserName;
        private string Password;
        public USER(string UserName, string Password)
        {
            this.UserName = UserName;
            this.Password = Password;
        }
        public string GetUserName()
        {
            return this.UserName;
        }
        public void SetUserName(string UserName)
        {
            this.UserName=UserName;
        }
        public string GetPassword()
        {
            return this.Password;
        }
        public void SetPassword(string Password)
        {
            this.Password=Password;
        }
    }
}
