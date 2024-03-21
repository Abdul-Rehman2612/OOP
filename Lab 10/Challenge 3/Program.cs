using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std = new Student("bscs", 4, 5000, "hira", "qwerty");
            Staff staff = new Staff("CITY",1000000,"Khadija","asdfghjkl");
            Console.WriteLine(std.getname());
            Console.WriteLine(staff.getname());
            Console.WriteLine(std.tostring());
            Console.WriteLine(staff.tostring());
            Console.ReadKey();
        }
    }
}
