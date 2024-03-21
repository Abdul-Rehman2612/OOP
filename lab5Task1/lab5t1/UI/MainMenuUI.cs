using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1
{
    internal class MainMenuUI
    {
        public static string Menu()
        {
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit");
            Console.WriteLine("4.View Register Students");
            Console.WriteLine("5.View Students for a specific program");
            Console.WriteLine("6.Register Student for a specific subject");
            Console.WriteLine("7.Calculate Fee for all students");
            Console.WriteLine("8.Exit");
            Console.Write("Enter option...");
            string option = Console.ReadLine();
            return option;
        }
        public static void PressAnyKey(string statement)
        {
            Console.WriteLine(statement);
            Console.Write("Press any key to continue...");
            Console.ReadKey();
        }
        public static void PrintStatement(string statement)
        {
            Console.Write(statement);
        }
    }
}
