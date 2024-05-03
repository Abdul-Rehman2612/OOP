using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<book> books = new List<book>();
            

            while (true)
            {
                Console.WriteLine("1) Add Book");
                Console.WriteLine("2) View all Book Information");
                Console.WriteLine("3) Get Author");
                Console.WriteLine("4) Sell Copies");
                Console.WriteLine("5) Restock");
                Console.WriteLine("6) Books Count");
                Console.WriteLine("7) Exit");
                
                Console.Write("Enter option: ");
                string option=Console.ReadLine();
                if(option == "1")
                {
                    Console.Write("Enter book name: ");
                    string bookname=Console.ReadLine();
                    Console.Write("Enter book author: ");
                    string author=Console.ReadLine();
                    Console.Write("Enter book year: ");
                    string year=Console.ReadLine();
                    Console.Write("Enter book Price: ");
                    float price=float.Parse(Console.ReadLine());
                    Console.Write("Enter book quantity: ");
                    int quantity= int.Parse(Console.ReadLine());
                    book Book1=new  book(bookname,author,year,price,quantity);
                    books.Add(Book1);

                }
                else if(option == "2")
                {
                    for(int i = 0; i < books.Count; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(books[i].bookDetails());
                        
                    }
                }
                else if(option == "3")
                {
                    Console.Write("Enter book name: ");
                    string name=Console.ReadLine();
                    for(int i = 0; i < books.Count; i++)
                    {
                        if (books[i].getTitle() == name)
                        {
                            Console.WriteLine("Author name is: "+ books[i].getAuthor());
                            break;
                        }
                    }

                }
                else if(option == "4")
                {
                    Console.Write("Enter book name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter number of copies: ");
                    int number=int.Parse(Console.ReadLine());
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].Book_title == name)
                        {
                            string result=books[i].sellCopies(number);
                            Console.WriteLine(result);
                            break;
                        }
                    }
                }
                else if(option == "5")
                {
                    Console.Write("Enter book name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter number of copies: ");
                    int number = int.Parse(Console.ReadLine());
                    for (int i = 0; i < books.Count; i++)
                    {
                        if (books[i].Book_title == name)
                        {
                            books[i].Restock(number);
                            break;
                        }
                    }
                }
                else if(option == "6")
                {
                    int quantity = 0;
                    for (int i = 0;i<books.Count; i++)
                    {
                        quantity = quantity + books[i].getQuantity();
                    }

                    Console.WriteLine("Quantity: "+quantity);
                }
                else if(option == "7")
                {
                    return;
                }
                else
                {
                    Console.WriteLine("You have enetered wrong information");
                }

            }


        }
    }
}
