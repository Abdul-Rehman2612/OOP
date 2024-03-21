using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5t1
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Clear();
                string option = MainMenuUI.Menu();
                if(option=="1")
                {
                    Console.Clear();
                    StudentBL student = StudentUI.GetStudentFromUser();
                    StudentDL.InsertStudentToDB(student);
                    MainMenuUI.PressAnyKey("Student added successfully!");
                }
                else if(option=="2")
                {
                    Console.Clear();
                }
                else if(option=="3")
                {
                    Console.Clear();
                    StudentDL.GenerateMerit();
                    MainMenuUI.PressAnyKey("Merit calculated successfully!");
                }
                else if (option=="4")
                {

                }
                else if (option=="5")
                {

                }
                else if (option=="6")
                {

                }
                else if (option=="7")
                {

                }
                else if (option=="8")
                {
                    Environment.Exit(0);
                }
                else
                {
                    MainMenuUI.PressAnyKey("Wrong user choice!");
                }
            }
        }
    }
}
