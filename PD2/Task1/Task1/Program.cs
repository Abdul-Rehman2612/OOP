using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using student.data;

namespace Task1
{
    internal class Program
    {
        static void Main()
        {
            Student[] s1 = new Student[2];
            for (int i = 0; i < s1.Length; i++)
            {
                s1[i] = TakeStudentInput();
            }
            Console.ReadKey();
            PrintData(s1);
        }
        static Student TakeStudentInput()
        {
            Console.WriteLine("This is my first code");
            Student s1 = new Student
            {
                studentName = Console.ReadLine(),
                matricMarks = float.Parse(Console.ReadLine()),
                interMarks = float.Parse(Console.ReadLine()),
                ecatMarks = float.Parse(Console.ReadLine()),
                aggregate = float.Parse(Console.ReadLine())
            };
            return s1;
        }
        static void PrintData(Student[] s1)
        {
            for (int i = 0; i < s1.Length; i++)
            {
                Console.WriteLine(s1[i].studentName + "    " + s1[i].matricMarks + "    " + s1[i].interMarks + "    " + s1[i].ecatMarks + "     " + s1[i].aggregate);
            }
        }
    }
}
