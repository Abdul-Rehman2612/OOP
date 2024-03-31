using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SignInSignUp.UTILITY
{
    internal class VALIDATIONS
    {
        public static string UsernameValidation(string username)
        {
            if (username.Length < 6 || username.Length > 12)
            {
                return "Username must be between 6 and 12 characters!";
            }
            foreach (char c in username)
            {
                if (c == ' ')
                {
                    return "Username cannot contain spaces!";
                }
                else if (!(char.IsDigit(c) || char.IsLetter(c)))
                {
                    return "Username can only contain letters and numbers!";
                }
            }
            return username;
        }
        public static string PasswordValidation(string password)
        {
            int numCount = 0;
            int charCount = 0;
            if (password.Length < 6 || password.Length > 12)
            {
                return "Password must be between 6 and 12 characters!";
            }
            foreach (char c in password)
            {
                if(c==' ')
                {
                    return "Password cannot consist of spaces!";
                }
                else if (char.IsDigit(c))
                {
                    numCount++;
                }
                else if (char.IsLetter(c))
                {
                    charCount++;
                }
            }
            if (numCount == 0 || charCount == 0)
            {
                return "Password must contain at least one letter and one number!";
            }
            return password;
        }
    }
}
