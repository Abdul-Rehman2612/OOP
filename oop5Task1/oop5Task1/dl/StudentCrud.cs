using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace oop5Task1
{
    internal class StudentCrud
    {
       public static List <Student>students=new List<Student> ();
        public static List<Student>TopTenStudents=new List<Student> ();    
        public static List<Student> GetStudnts()
        {
            return students;
        }
        public static void AddStudent(Student student)
        {
            students.Add(student);
        }
        public static Student RemoveStudentByName(string name)
        {
            foreach(Student student in students)
            {
                if(student.Name == name)
                {
                    students.Remove(student);
                }
            }
            return null;
            
        }
        public static void generateMeritList()
        {
            foreach (Student student in students)
            {
               
                
                List<Student> sortedStudents = students.OrderBy(s => s.Aggregate).ToList();

                // Get the first 10 students
                List<Student> firstTenStudents = sortedStudents.Take(10).ToList();

                // Display the first 10 students
                foreach (var Student in firstTenStudents)
                {
                    Console.WriteLine($"Name: {Student.Name}, Aggregate: {Student.Aggregate}");
                }

            }

        }
        public static void CalculateFees()
        {
            foreach (var Student in students)
            {
                double fees = 0;
                foreach (var sub in Student.RegisteredSubjects)
                {
                    fees = sub.Fee + fees;
                }
                Console.WriteLine(Student.Name + " fees = " + fees);
            }

        }

    }
}
