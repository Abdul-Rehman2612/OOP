using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Chaudhary;

namespace task
{
    internal class Program
    {
        static void Main()
        {
            Chaudhary0 person1 = new Chaudhary0();
            person1 = TakeInput();
            person1.checker=CastChecker(person1.cast);
            Chaudhary0 person = new Chaudhary0(person1.name, person1.age,person1.cast,person1.checker);
            Console.WriteLine(person.name+"  "+person.age+"   "+person.cast+"   "+person.checker);
        }
        static Chaudhary0 TakeInput()
        {
            Chaudhary0 s = new Chaudhary0();
            s.name = Console.ReadLine();
            s.age = int.Parse(Console.ReadLine());
            s.cast = Console.ReadLine();
            return s;
        }
        static bool CastChecker(string cast)
        {
            if (cast=="Chaudhary")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
