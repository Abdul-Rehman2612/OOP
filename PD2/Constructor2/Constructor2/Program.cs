using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Constructor2.DataFiles;

namespace Constructor2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Constructor st1 = new Constructor();
            st1.studentName=Console.ReadLine();
            st1.matricMarks=float.Parse(Console.ReadLine());
        }
    }
}
