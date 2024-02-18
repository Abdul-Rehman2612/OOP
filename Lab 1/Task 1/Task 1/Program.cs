using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your marks percentage: ");
            double percentage=double.Parse(Console.ReadLine());
            string grade = GradeCalculate(percentage);
            Console.WriteLine("Your grade is: {0}", grade);
            Console.ReadKey();
        }
        static string GradeCalculate(double percentage)
        {
            string Grade = "";
            if (percentage>=80)
            {
                Grade="A";
            }
            else if (percentage>=70)
            {
                Grade="B";
            }
            else if (percentage>=55)
            {
                Grade="C";
            }
            else if (percentage<55 && percentage>=40)
            {
                Grade="D";
            }
            else if(percentage<40)
            {
                Grade="F";
            }    
            return Grade;
        }
    }
}
