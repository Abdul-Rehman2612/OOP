using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Task2
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                Calculator nums = new Calculator();
                Console.WriteLine("Welcome to Basic Calculator App!");
                Console.Write("Enter number 1: ");
                nums.num1=double.Parse(Console.ReadLine());
                Console.Write("Enter number 2: ");
                nums.num2=double.Parse(Console.ReadLine());
                Console.Write("Enter the operation to perform(+,-,*,/): ");
                String option = Console.ReadLine();
                if (option =="+")
                {
                    nums.Add();
                }
                else if (option =="-")
                {
                    nums.Subtract();
                }
                else if (option =="*")
                {
                    nums.Product();
                }
                else if (option=="/")
                {
                    nums.Divide();
                }
                else
                {
                    Console.WriteLine("Wrong user choice!");
                }
                Console.WriteLine("Results: {0}", nums.result);
                Console.WriteLine("Press any key to continue!");
                Console.ReadKey();
            }
        }
    }
}
