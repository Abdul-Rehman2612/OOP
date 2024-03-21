using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Web;

namespace lab5t1
{
    internal class StudentDL
    {
        static SqlConnection connection = new SqlConnection("Server=DESKTOP-L60GA3Q;Database=UMS;Trusted_Connection=True;");
        public static void InsertStudent(StudentBL student)
        {
            bool check=InsertStudentToDB(student);
            if(check==true)
            {
                MainMenuUI.PressAnyKey("Student added successfully!");
            }
        }
        public static bool InsertStudentToDB(StudentBL student)
        {
            connection.Open();
            string query = ($"Insert into StudentTbl(StudentName,StudentAge,StudentFscMarks,StudentEcatMarks) Values('{student.GetStudentName()}','{student.GetStudentAge()}','{student.GetFscMarks()}','{student.GetEcatMarks()}')");
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
            return true;
        }
        public static void GenerateMerit()
        {
            connection.Open();
            string query = ($"UPDATE StudentTbl SET StudentMerit = (StudentFscMarks * 60.0 / 1100) + (StudentEcatMarks * 40.0 / 400.0);");
            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.ExecuteNonQuery();
            connection.Close();
        }
    }
}
