using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BMW B=new BMW("123","A!","Black","BMW",100000,false,false);
            AUDI A = new AUDI("A5", false, false, true, "2023", "White", 100000);
            Console.Write(A.GetNightVisionAssistant()+"   "+A.GetModel());
            Console.ReadKey();
            A.SetNightVisionAssistant();
            Console.Write(A.GetNightVisionAssistant());
            Console.ReadKey();
        }
    }
}
