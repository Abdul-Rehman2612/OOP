using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task_2.BL;

namespace Task_2
{
    internal class Program
    {
        static void Main()
        {
            List<Customer> customers = new List<Customer>();
            while(true)
            {
                Console.Clear();
                Console.Write("Enter customer Name: ");
                string name=Console.ReadLine();
                Console.Write("Enter address: ");
                string address=Console.ReadLine();
                Console.Write("Enter contact: ");
                string contact=Console.ReadLine();
                Customer c=new Customer(name, address, contact);
                while(true)
                {
                    Console.Write("Enter 1 to add new product: ");
                    string option=Console.ReadLine();
                    if(option=="1")
                    {
                        Console.Write("Enter product Name: ");
                        string Pname = Console.ReadLine();
                        Console.Write("Enter product category: ");
                        string Category = Console.ReadLine();
                        Console.Write("Enter product price: ");
                        double price = double.Parse(Console.ReadLine());
                        Products p=new Products(Pname, Category,price);
                        c.addProducts(p);
                    }
                    else
                    {
                        customers.Add(c);
                        break;
                    }
                }
                for(int i=0;i<customers.Count;i++)
                {
                    Console.Write(customers[i].Name+"    "+customers[i].Contact);
                    for(int j = 0; j<customers[i].products.Count;j++)
                    {
                        Console.Write(customers[j].products[j].name+"   "+customers[j].products[j].price);
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
