using course.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace student.data
{
    internal class Student
    {
        public string studentName;
        public string studentID;
        public string studentPassword;
        public List<Courses> studentCourses= new List<Courses>();
        public Student(string Name, string ID, string Password)
        {
            this.studentName = Name;
            this.studentID = ID;
            this.studentPassword = Password;
        }
        public void AddCourses(Courses n)
        {
            studentCourses.Add(n);
        }
    }
}
