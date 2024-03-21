using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mountainbike bike = new Mountainbike(10,11,12,13);
            
            Console.WriteLine(bike.getcadence());
            bike.setSpeed(20);
            Console.WriteLine(bike.getspeed());
            Console.ReadKey();
        }
    }
}
