using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_2
{
    internal class Program
    {
        static void Main()
        {
            MountainBike m = new MountainBike(123, 123, 123, 123);
            Console.WriteLine(m.GetSpeed()+"  "+m.GetCadence());
            Console.ReadKey();
        }
    }
}
