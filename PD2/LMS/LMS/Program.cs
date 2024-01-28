
using course.data;
using teacher.data;
using student.data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;
using System.ComponentModel.Design;
using System.Security.Claims;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Runtime.Remoting.Messaging;

namespace LMS
{
    internal class Program
    {
        static void Main()
        {
            List<Student> student = new List<Student>();
            List<Teacher> teacher = new List<Teacher>();
            List<Courses> course = new List<Courses>();
            string[] mainMenu = new string[4] { "                                 Welcome to LMS!", "1.Sign Up", "2.Sign In", "3.Exit" };
            string[] studentMenu = new string[4] { "1.View available courses", "2.Register course","3.View enrolled courses","4.Exit" };
            string[] teacherMenu = new string[4] { "1.View available courses", "2.Add course","3.View students enrolled", "4.Exit" };

            string option="";
            while(option!="3")
            {
                Console.Clear();
                option=PrintMenu(mainMenu);
                if(option=="1")
                {
                    Console.Clear();
                    string name;
                    string id;
                    string password;
                    Console.Write("Enter your name: ");
                    name= Console.ReadLine();
                    Console.Write("Enter userID: ");
                    id=Console.ReadLine();
                    Console.Write("Enter password: ");
                    password= Console.ReadLine();
                    Console.Write("Enter role(1.Teacher ,2.Student): ");
                    string role=Console.ReadLine();
                    if((role=="1" || role=="Teacher") && UserCheck(student,teacher,id)==false )
                    {
                        Teacher t=new Teacher(name, id, password);
                        teacher.Add(t);
                        Console.WriteLine("Successfully signed up!");
                    }
                    else if((role=="2" || role=="Student") && UserCheck(student, teacher, id)==false)
                    {
                        Student s=new Student(name,id, password);
                        student.Add(s);
                        Console.WriteLine("Successfully signed up!");
                    }
                    else
                    {
                        Console.WriteLine("Sign up failed!");
                    }
                    Console.WriteLine("Press any key to continue!");
                    Console.ReadKey();
                }
                else if(option=="2")
                {
                    Console.Clear();
                    string id;
                    string password;
                    Console.Write("Enter userID: ");
                    id=Console.ReadLine();
                    Console.Write("Enter password: ");
                    password= Console.ReadLine();
                    string role=UserSignInCheck(student,teacher,id,password);
                    if(role=="Teacher")
                    {
                        string choice="";
                        while (choice!="4")
                        {
                            Console.Clear();
                            choice = PrintMenu(teacherMenu);
                            if (choice=="1")
                            {
                                Console.Clear();
                                PrintCourses(course);
                                PressAnyKey();
                            }
                            else if (choice=="2")
                            {
                                AddCourse(course);
                                Console.Clear();
                            }
                            else if (choice=="3")
                            {
                                Console.Clear();
                                Console.WriteLine($"{"StudentName",-20}{"CourseID",-20}{"CourseName"}");
                                for (int i = 0; i<student.Count; i++)
                                { 
                                    PrintStudentsEnrolled(student,i);
                                }
                                PressAnyKey();
                            }
                            else if (choice=="4")
                            {
                                break;
                            }
                        }    
                    }
                    else if(role=="Student")
                    {
                        string choice="";
                        while (choice!="4")
                        {
                            Console.Clear();
                            int index = IndexCheck(student,id,password);
                            choice = PrintMenu(studentMenu);
                            if (choice=="1")
                            {
                                Console.Clear();
                                PrintCourses(course);
                                PressAnyKey();
                            }
                            else if (choice=="2")
                            {
                                Console.Clear();
                                PrintCourses(course);
                                if(course.Count>0)
                                {
                                    int idx=RegisterCourse(course);
                                    if (idx!=-1)
                                    {
                                        Courses n = new Courses(course[idx].courseID, course[idx].courseName);
                                        student[index].AddCourses(n);
                                        Console.WriteLine("Course registered successfully!");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Course not registered!");
                                    }
                                }
                                PressAnyKey();
                            }
                            else if (choice=="3")
                            {
                                Console.Clear();
                                if (student[index].studentCourses.Count>0)
                                {
                                    PrintStudentsEnrolled(student, index);
                                }
                                else
                                {
                                    Console.WriteLine("No course registered!");
                                }
                                PressAnyKey();
                            }
                            else if (choice=="4")
                            {
                                break;
                            }
                        }

                    }
                }
                else if(option=="4")
                {
                    Console.Clear();
                    Environment.Exit(0);
                }
            }
        }
        static string PrintMenu(string[] menu)
        {
            for(int i=0;i<menu.Length;i++)
            {
                Console.WriteLine(menu[i]);
            }
            Console.Write("Enter option...");
            string option = Console.ReadLine();
            return option;
        }
        static bool UserCheck(List<Student> student,List<Teacher> teacher,string id)
        {
            bool check=false;
            for(int i=0;i<student.Count;i++)
            {
                if (student[i].studentID==id)
                {
                    check= true;
                }
            }
            for(int j=0;j<teacher.Count;j++)
            {
                if (teacher[j].teacherID==id)
                {
                   check=true;
                }
            }
            return check;
        }
        static void AddCourse(List<Courses> course)
        {
            Console.Write("Enter course ID: ");
            string courseID=Console.ReadLine();
            Console.Write("Enter course name: ");
            string courseName=Console.ReadLine();
            if(CourseCheck(courseName,courseID,course)==false)
            {
                Courses courseTemp = new Courses(courseID,courseName);
                course.Add(courseTemp);
                Console.WriteLine("Course added successfully!");
            }
            else
            {
                Console.WriteLine("Course not added!");
            }
            PressAnyKey();
        }
        static bool CourseCheck(string courseName,string courseID,List<Courses> course)
        {
            for(int i=0;i<course.Count;i++)
            {
                if (course[i].courseID==courseID)
                {
                    return true;
                }
            }
            return false;
        }
        static string UserSignInCheck(List<Student> student,List<Teacher> teacher,string id,string password)
        {
            for (int i = 0; i<student.Count; i++)
            {
                if (student[i].studentID==id && student[i].studentPassword==password)
                {
                    return "Student";
                }
            }
            for (int i = 0; i<teacher.Count; i++)
            {
                if (teacher[i].teacherID==id && teacher[i].teacherPassword==password)
                {
                    return "Teacher";
                }
            }
            return "Wrong User";
        }
        static void PrintCourses(List<Courses> course)
        {
            if(course.Count>0)
            {
                for (int i = 0; i<course.Count; i++)
                {
                    Console.WriteLine($"{course[i].courseID,-20}{course[i].courseName,-20}");
                }
            }
            else
            {
                Console.WriteLine("No course available!");
            }
        }
        static int IndexCheck(List<Student> student,string id,string password)
        {
            for(int i = 0; i<student.Count; i++)
            {
                if (student[i].studentID==id && student[i].studentPassword==password)
                {
                    return i;
                }
            }
            return 0;
        }
        static void PrintStudentsEnrolled(List<Student> student,int i)
        {
            if (student[i].studentCourses.Count>0)
            {
                for (int j = 0; j<student[i].studentCourses.Count; j++)
                {
                    Console.WriteLine($"{student[i].studentName,-20}{student[i].studentCourses[j].courseID,-20}{student[i].studentCourses[j].courseName,-20}");
                }
            }
        }
        static int RegisterCourse(List<Courses> course)
        {
            Console.WriteLine("Enter the course to register: ");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine(course.Count);
            if(n-1<course.Count && n-1>=0)
            {
                return n-1;
            }
            return -1; 
        }
        static void PressAnyKey()
        {
            Console.Write("Press any key to continue!");
            Console.ReadKey();
        }
    }
}
