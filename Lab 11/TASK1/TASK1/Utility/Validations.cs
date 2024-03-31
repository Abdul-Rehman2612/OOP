using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TASK1.Utility
{
    internal class Validations
    {
        public static string NameInputCheck(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                foreach (char c in text)
                {
                    if ((c < 'a' || c > 'z') && (c < 'A' || c > 'Z') && c != ' ')
                    {
                        return "Name must consist of alphabets only!";
                    }
                }
                if (text.Length>55)
                {
                    return "Name must be smaller than 55 characters!";
                }
                if (text[0]<'A' || text[0]>'Z')
                {
                    return "First letter must be capital!";
                }

            }
            else
            {
                return "Name cannot be null!";
            }
            return "True";
        }
        public static bool IsValidNumber(string number)
        {
            foreach (char c in number)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
