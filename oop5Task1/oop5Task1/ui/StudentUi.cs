using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop5Task1
{
    internal class StudentUi
    {
        public static Student GetStudentFromUser()
        {
            
            Console.WriteLine("Enter Student Name: ");
            string Name=Console.ReadLine();
            Console.WriteLine("Enter Student age: ");
            int Age =int.Parse(Console.ReadLine());
            Console.WriteLine("Enter FSC marks");
            double FscMarks=double.Parse( Console.ReadLine());
            Console.WriteLine("Ecat Marks: ");
            double EcatMarks=double.Parse( Console.ReadLine());
            int numberOfPref = 0;
            Student student = new Student(Name,Age,FscMarks,EcatMarks);
            Console.WriteLine("Enter number of pref");
            numberOfPref = int.Parse((Console.ReadLine()));
            for (int i = 0; i < numberOfPref; i++)
            {
                if (GetUserPref() != null )
                {
                    student.AddPreference(GetUserPref());
                    
                }
                else if ( GetUserPref() == null)
                {
                    Console.WriteLine("wrong preference Entered");
                }
            }
            return student;


        }
        public static bool InsertStudentToDB(Student student)
        {
            SqlConnection connection = new SqlConnection("Server=DESKTOP-4ITHIC0\\MSSQLSERVER01; Database=UMS;Trusted_Connection=true;");
            connection.Open();
            string query = $"Insert into AddStudent(name,age,fsc ,ecat) Values('{student.Name}','{student.Age}','{student.FscMarks}','{student.EcatMarks}')";
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        public static DegreeProgram GetUserPref()
        {
            Console.WriteLine("Enter your pref");
            string preff = Console.ReadLine();
            DegreeProgram program = new DegreeProgram();
             program=   DegreeProgramDL.IsDegreeExist(preff);
            if (program != null)
            {
                return program;
            }
            else
            {
                return null;
            }
        }

        public static void DisplayStudent(Student student)
        {
            Console.WriteLine(student.Name);
        }
        public static void DisplayStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                DisplayStudent(student);
            }

        }
       public static void ViewStudentsOFSpecificProgram(DegreeProgram program)
        {
            foreach (var student in StudentCrud.students)
            {
                if(student.EnrolledProgram==program)
                {
                    Console.WriteLine($"Name: {student.Name}, Aggregate: {student.Aggregate}");
                }
            }
        }
       
    }
}
