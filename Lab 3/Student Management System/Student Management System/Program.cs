using Student_Management_System.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_Management_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Students> students=new List<Students>();
            while (true)
            {
                Console.Clear();
                string option=PrintMenu();
                if(option =="1")
                {
                    Console.Clear();
                    Students s=AddStudents();
                    students.Add(s);
                }
                else if(option =="2")
                {
                    Console.Clear();
                    PrintStudentsData(students);
                }
                else if (option =="3")
                {
                    Console.Clear();
                    CalculateAggregate(students);
                }
                else if (option =="4")
                {
                    Console.Clear();
                    TopStudents(students);
                }
                else if(option=="5")
                {
                    Environment.Exit(0);
                }
            }
        }
        static Students AddStudents()
        {
            Console.Write("Enter student name: ");
            string studentName = Console.ReadLine();
            Console.Write("Enter matric marks(Out of 1100): ");
            float matricMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter inter marks(Out of 1100): ");
            float interMarks = float.Parse(Console.ReadLine());
            Console.Write("Enter ecat marks(Out of 400): ");
            float ecatMarks = float.Parse(Console.ReadLine());
            Students s = new Students(studentName, matricMarks, interMarks, ecatMarks);
            Console.WriteLine("Student data added!");
            PressAnyKey();
            return s;
        }
        static string PrintMenu()
        {
            Console.WriteLine("              Welcome to Student Management System");
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.View Students");
            Console.WriteLine("3.Calculate Aggregate");
            Console.WriteLine("4.Top Students");
            Console.WriteLine("5.Exit");
            Console.Write("Enter option...");
            string option=Console.ReadLine();
            return option;
        }
        static void PrintStudentsData(List<Students> students)
        {
            Console.WriteLine($"{"Student Name",-20}{"Matric Marks",-15}{"Inter Marks",-15}{"ECAT Marks",-15}{"Aggregate"}");
            if (students.Count<1)
            {
                Console.WriteLine("No students data available!");
            }
            else
            {
                for (int i = 0; i<students.Count; i++)
                {
                    Console.WriteLine($"{students[i].name,-20}{students[i].matricMarks,-15}{students[i].interMarks,-15}{students[i].ecatMarks,-15}{students[i].aggregate}");
                }
                Console.WriteLine("If aggregate is 0, use calculate aggregate feature to calculate aggregates of students!");
            }
            PressAnyKey();
        }
        static void CalculateAggregate(List<Students> students)
        {
            if (students.Count<1)
            {
                Console.WriteLine("No students data available!");
            }
            else
            {
                for(int i=0; i<students.Count;i++)
                {
                    students[i].CalculateAgg(students[i]);
                }
                Console.WriteLine("Aggregate Calculated Successfully!");
            }
            PressAnyKey();
        }
        static void TopStudents(List<Students> students)
        {
            if (students.Count < 1)
            {
                Console.WriteLine("No students data available!");
            }
            else
            {
                Console.WriteLine("Top 3 Students:");
                Console.WriteLine($"{"Student Name",-20}{"Matric Marks",-15}{"Inter Marks",-15}{"ECAT Marks",-15}{"Aggregate"}");
                List<Students> studentss = students.OrderByDescending(student => student.aggregate).ToList();
                for (int i = 0; i < Math.Min(3, studentss.Count); i++)
                {
                    Console.WriteLine($"{studentss[i].name,-20}{studentss[i].matricMarks,-15}{studentss[i].interMarks,-15}{studentss[i].ecatMarks,-15}{studentss[i].aggregate}");
                }
            }
            PressAnyKey();
        }
        static void PressAnyKey()
        {
            Console.Write("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
