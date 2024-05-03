using System;
using CalculatorApp.BL;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = null;

            while (true)
            {
                Console.WriteLine("\nMenu Options:");
                Console.WriteLine("1. Create a Single Object of Calculator");
                Console.WriteLine("2. Change Values of Attributes");
                Console.WriteLine("3. Add");
                Console.WriteLine("4. Subtract");
                Console.WriteLine("5. Multiply");
                Console.WriteLine("6. Divide");
                Console.WriteLine("7. Modulo");
                Console.WriteLine("8. Exit");

                Console.Write("Enter your choice (1-8): ");
                string choice = Console.ReadLine();
                Console.Clear();

                switch (choice)
                {
                    case "1":
                        if (calculator == null)
                        {
                            calculator = new Calculator();
                            Console.WriteLine("Calculator object created with default values (10, 10)");
                        }
                        else
                        {
                            Console.WriteLine("Calculator object already exists. You can change the values of attributes.");
                        }
                        break;
                    case "2":
                        if (calculator != null)
                        {
                            Console.Write("Enter the new value for number1: ");
                            calculator.Number1 = double.Parse(Console.ReadLine());
                            Console.Write("Enter the new value for number2: ");
                            calculator.Number2 = double.Parse(Console.ReadLine());
                            Console.WriteLine("Values updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Please create the Calculator object first.");
                        }
                        break;
                    case "3":
                        if (calculator != null)
                        {
                            Console.WriteLine("Result of addition: " + calculator.Add());
                        }
                        else
                        {
                            Console.WriteLine("Please create the Calculator object first.");
                        }
                        break;
                    case "4":
                        if (calculator != null)
                        {
                            Console.WriteLine("Result of subtraction: " + calculator.Subtract());
                        }
                        else
                        {
                            Console.WriteLine("Please create the Calculator object first.");
                        }
                        break;
                    case "5":
                        if (calculator != null)
                        {
                            Console.WriteLine("Result of multiplication: " + calculator.Multiply());
                        }
                        else
                        {
                            Console.WriteLine("Please create the Calculator object first.");
                        }
                        break;
                    case "6":
                        if (calculator != null)
                        {
                            Console.WriteLine("Result of division: " + calculator.Divide());
                        }
                        else
                        {
                            Console.WriteLine("Please create the Calculator object first.");
                        }
                        break;
                    case "7":
                        if (calculator != null)
                        {
                            Console.WriteLine("Result of modulo: " + calculator.Modulo());
                        }
                        else
                        {
                            Console.WriteLine("Please create the Calculator object first.");
                        }
                        break;
                    case "8":
                        Console.WriteLine("Exiting...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 8.");
                        break;
                }
            }
        }
    }
}
