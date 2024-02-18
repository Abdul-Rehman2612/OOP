using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number: ");
            double number=Double.Parse(Console.ReadLine());
            string numberCh = NumberCheck(number);
        }
        static string NumberCheck(double number)
        {
            if (number < 0)
            {
                return "Negative";
            }
            else if(number>0)
            {
                return "Positve";
            }
            else if(number==0)
            {
                return "Zero";
            }
            return number.ToString();
        }
    }
}
