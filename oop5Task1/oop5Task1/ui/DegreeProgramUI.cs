using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5Task1.ui
{
    internal class DegreeProgramUI
    {
        public static DegreeProgram GetDegreeFromUser()
        {
            DegreeProgram degreeProgram = new DegreeProgram();
            Console.WriteLine("Enter degree title");
            degreeProgram.Title = Console.ReadLine();
            Console.WriteLine("Enter Duration ");
            degreeProgram.Duration = Console.ReadLine();
            Console.WriteLine("Enter Number of seats: ");
            degreeProgram.Seats = Console.ReadLine();

            Console.WriteLine("How many subjects you have in this degree");
            string subjectscoun = Console.ReadLine();
            int subjectscount = int.Parse(subjectscoun);
            List<Subject> subjects = new List<Subject>();
            for (int i = 0; i < subjectscount; i++)
            {
                //you can add condition if the subject is already in the subject
                //list do not add that subject
                subjects.Add(GetSubjectsFromUser());
            }

            degreeProgram.Subjects = subjects;

            return degreeProgram;

        }

        public static Subject GetSubjectsFromUser()
        {
            Subject subject = new Subject();
            Console.WriteLine("Enter Subject Code ");
            subject.Code = Console.ReadLine();
            Console.WriteLine("Enter Subject Credit Hours");
            subject.CreditHours = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fee for the subject ");
            subject.Fee = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Type of the subject");
            subject.SubjectType = Console.ReadLine();
            return subject;
        }
    }
}

