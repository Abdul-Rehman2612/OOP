using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_1.BL;

namespace Task_1
{
    internal class Program
    {
        static void Main()
        {
            List<student> students = new List<student>();
            while(true)
            {
                Console.Clear();
                Console.Write("Enter student name: ");
                string name=Console.ReadLine();
                Console.Write("Enter RollNo: ");
                string rollNo=Console.ReadLine();
                Console.Write("Enter Matric Marks(out of 1100): ");
                double matricMarks=double.Parse(Console.ReadLine());
                Console.Write("Enter FSC Marks(out of 1100): ");
                double fscMarks=double.Parse(Console.ReadLine());
                Console.Write("Enter HomeTown address: ");
                string homeTown=Console.ReadLine();
                bool hostelite;
                while(true)
                {
                    Console.Write("Is hostelite(Y/N): ");
                    string option=Console.ReadLine();
                    if(option=="y" || option=="Y")
                    {
                        hostelite=true;
                        break;
                    }
                    else if(option=="n" || option=="N")
                    {
                        hostelite=false;
                        break;
                    }
                }
                student s = new student(name, rollNo, matricMarks, fscMarks, homeTown, hostelite);
                students.Add(s);
                for(int i=0;i<students.Count;i++)
                {
                    Console.WriteLine(students[i].name+"   "+students[i].calculateMerit());
                }
                Console.ReadKey();
            }
        }
    }
}
