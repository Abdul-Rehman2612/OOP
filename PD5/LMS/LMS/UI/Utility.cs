using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.UI
{
    internal class Utility
    {
        public static string[] Menu = new string[] { "Add Student","Add Degree Program","Generate Merit","View Registered Students","View Students of a specific program","Register Subjects for a specific student","Calculate fee for all registered students","Exit" };
        public static string MainMenu()
        {
            int i = 1;
            foreach(string s in Menu)
            {
                Console.WriteLine($"{i}-{s}");
                i++;
            }
            Console.Write("Enter option...");
            return Console.ReadLine();
        }
    }
}
