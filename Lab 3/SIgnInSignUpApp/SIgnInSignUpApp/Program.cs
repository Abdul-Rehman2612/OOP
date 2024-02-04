using System;
using System.Collections.Generic;
using System.IO;

namespace SIgnInSignUpApp
{
    internal class Program
    {
        static void Main()
        {
            List<User> users = new List<User>();
            UsersDataLoad(users);
            while(true)
            {
                Console.Clear();
                string option = PrintMenu();
                if(option=="1")
                {
                    Console.Clear();
                    UserSignUp(users);
                }
                else if(option=="2")
                {
                    Console.Clear();
                    PrintStatement("     User Sign In\n");
                    PrintStatement("Enter username: ");
                    string username = Console.ReadLine();
                    PrintStatement("Enter password: ");
                    string password = Console.ReadLine();
                    if(UserCheck(users,username)==true)
                    {
                        int idx = Index(users, username);
                        if (password==users[idx].password)
                        {
                            PressAnyKey($"{"Successfully signed in as "+users[idx].role+"\n"}");
                        }
                        else
                        {
                            PressAnyKey("Wrong credentials! Sign In failed!\n");
                        }
                    }
                    else
                    {
                        PressAnyKey("Wrong credentials! Sign In failed!\n");
                    }
                }
                else if(option=="3")
                {
                    Environment.Exit(0);
                }
                else
                {
                    PressAnyKey("Wrong user choice!");
                }
            }
        }
        static void UserSignUp(List<User> users)
        {
            User u= new User();
            PrintStatement("     User Sign Up\n");
            PrintStatement("Enter Username: ");
            string username = Console.ReadLine();
            PrintStatement("Enter password(min 4 characters): ");
            string password = Console.ReadLine();
            PrintStatement("Enter role (Admin,Employee or Customer): ");
            string role = Console.ReadLine();
            if(UserCheck(users,username)==false)
            {
                if(password.Length>=4)
                {
                    if(RoleCheck(role)==true)
                    {
                        User user = new User(username,password,role);
                        users.Add(user);
                        UserNewDataFile(users);
                        PressAnyKey("Signed up successfully!\n");
                    }
                    else
                    {
                        PressAnyKey("Wrong user role! SignUp failed!\n");
                    }
                }
                else
                {
                    PressAnyKey("Password length less than 4! SignUp failed!\n");
                }
            }
            else
            {
                PressAnyKey("Username already exists! SignUp failed!\n");
            }
        }
        static int Index(List<User> users,string username)
        {
            for (int i = 0; i<users.Count; i++)
            {
                if (users[i].userName==username)
                {
                    return i;
                }
            }
            return -1;
        }
        static bool RoleCheck(string role)
        {
            if(role=="Admin" || role=="admin" || role=="ADMIN")
            {
                return true;
            }
            else if (role=="Employee" || role=="employee" || role=="EMPLOYEE")
            {
                return true;
            }
            else if (role=="User" || role=="user" || role=="USER")
            {
                return true;
            }
            return false;
        }
        static bool UserCheck(List<User> users,string username)
        {
            for(int i=0;i<users.Count; i++)
            {
                if (users[i].userName==username)
                {
                    return true;
                }
            }
            return false;
        }
        static string PrintMenu()
        {
            PrintStatement("     Welcome to Railways Reservation System!\n1.Sign Up\n2.Sign In\n3.Exit\n");
            Console.Write("Enter option...");
            return Console.ReadLine();
        }
        static void PrintStatement(string statement)
        {
            Console.Write(statement);
        }
        static void PressAnyKey(string statement)
        {
            PrintStatement(statement);
            Console.Write("Press any key to continue!");
            Console.ReadKey();
        }
        static void UserNewDataFile(List<User> user)
        {
            StreamWriter UserFile = new StreamWriter("Users.txt", true);

            UserFile.WriteLine($"{user[user.Count - 1].userName};{user[user.Count - 1].password};{user[user.Count - 1].role};;");

            UserFile.Close();
        }
        static void UsersDataLoad(List<User> users)
        {
            if(File.Exists("Users.txt"))
            {
                StreamReader UserFile = new StreamReader("Users.txt");
                string line;
                while ((line = UserFile.ReadLine()) != null)
                {
                    int j = 0;
                    User u = new User();
                    u.userName = LoadUserAttribute(line, ref j);
                    j++;
                    u.password = LoadUserAttribute(line, ref j);
                    j++;
                    u.role = LoadUserAttribute(line, ref j);
                    j++;
                    users.Add(u);
                }
                UserFile.Close();
            }
            
        }
        static string LoadUserAttribute(string line, ref int idx)
        {
            string n = "";
            while (line.Length > idx)
            {
                n = string.Concat(n, line[idx]);
                idx++;
                if (line[idx]==';')
                {
                    break;
                }
            }
            return n;
        }
    }
}