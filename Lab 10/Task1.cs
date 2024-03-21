using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hostellite s = new Hostellite("Abdul Rehman","2023-2027",254,897,205,false,true,false);
            Console.WriteLine(s.GetName()+"   "+s.GetSession()+"   "+s.CalculateMerit()+"  "+s.GetDayScholar());
            Console.ReadKey();
            DayScholar D = new DayScholar("Abdul Rehman", "2023-2027", 254, 897, 21, 60, true,true);
            Console.WriteLine(D.GetName()+"   "+D.GetSession()+"   "+D.CalculateMerit()+"   "+D.GetDayScholar());
            Console.ReadKey();
        }
    }
}
