
using System;
using System.Collections.Generic;
using System.Linq;
using Products_Management_System.data;

namespace Products_Management_System
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Products> products = new List<Products>();
                while (true)
                {
                    Console.Clear();
                    string option = PrintMenu();
                    if (option =="1")
                    {
                        Console.Clear();
                        Products p = AddProducts();
                        products.Add(p);
                    }
                    else if (option =="2")
                    {
                        Console.Clear();
                        PrintProductsData(products);
                    }
                    else if (option =="3")
                    {
                        Console.Clear();
                        CalculateProductsWorth(products);
                    }
                    else if (option =="4")
                    {
                        Environment.Exit(0);
                    }
                }
            }
            static Products AddProducts()
            {
                Console.Write("Enter product ID: ");
                string id = Console.ReadLine();
                Console.Write("Enter product name: ");
                string name = Console.ReadLine();
                Console.Write("Enter product category: ");
                string category = Console.ReadLine();
                Console.Write("Enter product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Enter brand name: ");
                string brand = Console.ReadLine();
                Console.Write("Enter country name: ");
                string country = Console.ReadLine();
                Products p = new Products(id,name,category,brand,price, country);
                Console.WriteLine("Product data added!");
                PressAnyKey();
                return p;
            }
            static string PrintMenu()
            {
                Console.WriteLine("           Products Management System");
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.View Products");
                Console.WriteLine("3.Calculate Total Worth");
                Console.WriteLine("4.Exit");
                Console.Write("Enter option...");
                string option = Console.ReadLine();
                return option;
            }
            static void PrintProductsData(List<Products> products)
            {
                if (products.Count<1)
                {
                    Console.WriteLine("No students data available!");
                }
                else
                {
                    Console.WriteLine($"{"Product ID",-20}{"Product Name",-20}{"Product Category",-20}{"Product Brand",-20}{"Product Country",-20}{"Product Price",-20}");
                    for (int i = 0; i<products.Count; i++)
                    {
                        Console.WriteLine($"{products[i].ID,-20}{products[i].Name,-20}{products[i].Category,-20}{products[i].BrandName,-20}{products[i].Country,-20}{products[i].Price}");
                    }
                }
                PressAnyKey();
            }
            static void CalculateProductsWorth(List<Products> products)
            {
                if (products.Count<1)
                {
                    Console.WriteLine("No products data available!");
                }
                else
                {
                    double totalWorth = 0.0;
                    for (int i = 0; i<products.Count; i++)
                    {
                    totalWorth+=products[i].Price;
                    }
                    Console.WriteLine("Total products price: {0}",totalWorth);
                }
                PressAnyKey();
            }
            static void PressAnyKey()
            {
                Console.Write("Press any key to continue!");
                Console.ReadKey();
            }
        }
    }
