using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5Task1
{
    internal class MainMenuUi
    {
       public static int Menu()
        {
            int choice;
            Console.WriteLine("Student Management System");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. Add Degree Program");
            Console.WriteLine("3. Generate Merit");       
            Console.WriteLine("4.View Register Students");
            Console.WriteLine("5.View Students for a specific program");
            Console.WriteLine("6.Register Student for a specific subject");
            Console.WriteLine("7.Calculate Fees for Registered  students");
            Console.WriteLine("8.Exit");
            choice =int.Parse(Console.ReadLine());
            return choice;
        }
    }
}
