using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1
{
    internal class StudentUI
    {
        public static StudentBL GetStudentFromUser()
        {
            Console.Write("Enter student name ");
            string studentName = Console.ReadLine();
            double fscMarks = NumberInput("Enter FSC Marks: ");
            double ecatMarks = NumberInput("Enter ECAT Marks: ");
            int age = NumberInput("Enter your age: ");
            StudentBL student = new StudentBL(studentName,age,fscMarks,ecatMarks);
            return student;
        }
        public static bool NumberCheck(string code)
        {
            bool check = true;
            int i = 0;
            while (i < code.Length)
            {
                if (code[i] < '0' || code[i] > '9')
                {
                    check = false;
                    break;
                }
                i++;
            }
            return check;
        }
        public static int NumberInput(string statement)
        {
            int number;
            while (true)
            {
                MainMenuUI.PrintStatement(statement);
                string input = Console.ReadLine();
                if (NumberCheck(input))
                {
                    number=int.Parse(input);
                    if(number>0) { return number; }
                }
            }
        }
    }
}
