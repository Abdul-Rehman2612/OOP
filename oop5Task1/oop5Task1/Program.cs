using oop5Task1.ui;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace oop5Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleUtility.MainHeader();
            int option = 0; 
            while(option != 8) 
            {
                option = MainMenuUi.Menu();
                if (option == 1)
                {
                    Student st=StudentUi.GetStudentFromUser();
                    double aggregate = (st.EcatMarks / 1100 * 60);
                    st.Aggregate = aggregate;
                    StudentUi.InsertStudentToDB(st);
                    //StudentCrud.AddStudent(st);
                }
                else if (option == 2) //add degree program
                {
                    DegreeProgram degree= DegreeProgramUI.GetDegreeFromUser();
                    DegreeProgramDL.AddDegree(degree);
                }
                else if(option == 3)  //generate merit
                {
                    StudentCrud.generateMeritList();
                    
                }
                else if( option == 4)
                {
                    StudentUi.DisplayStudents(StudentCrud.students);
                }
                else if(option == 5) //view students for a specific 
                {

                }
                else if(option==6)
                {

                }
                else if(option==7) 
                {
                    StudentCrud.CalculateFees();

                }
                else if(option==8)
                {
                    break;

                }
                else
                {
                    Console.WriteLine("Incorrect option selected.");
                }
                Console.ReadLine();
            }

        }
    }
}
