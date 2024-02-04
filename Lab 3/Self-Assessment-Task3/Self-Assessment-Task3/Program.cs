using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Task3
{
    internal class Program
    {
        static void Main()
        {
            ATM balance = new ATM();
            while (true)
            {
                Console.Clear();
                string option = PrintMenu();
                if (option=="1")
                {
                    Console.Clear();
                    Console.Write("Enter the amount to deposit: ");
                    double amount = double.Parse(Console.ReadLine());
                    balance.DepositMoney(amount);
                    Console.WriteLine("Money deposited successfully!");
                    PressAnyKey();
                }
                else if (option=="2")
                {
                    Console.Clear();
                    Console.Write("Enter the amount to withdraw: ");
                    double amount = double.Parse(Console.ReadLine());
                    if (amount>balance.balance)
                    {
                        Console.WriteLine("Withdrawl amount cannot be greater than the total balance!");
                    }
                    else
                    {
                        balance.WithDrawMoney(amount);
                        Console.WriteLine("Money withdrawn successfully!");
                    }
                    PressAnyKey();
                }
                else if(option=="3")
                {
                    Console.Clear();
                    Console.WriteLine("Your current balance is: {0}", balance.balance);
                    PressAnyKey();
                }
                else if(option=="4")
                {
                    Console.Clear();
                    TransactionHistory(balance);
                    PressAnyKey();
                }
            }
        }
        static string PrintMenu()
        {
            Console.WriteLine("Welcome to ATM");
            Console.WriteLine("1.Deposit money");
            Console.WriteLine("2.Withdraw money");
            Console.WriteLine("3.Check balance");
            Console.WriteLine("4.Transaction history");
            Console.WriteLine("5.Exit");
            Console.Write("Enter option...");
            string option = Console.ReadLine();
            return option;
        }
        static void PressAnyKey()
        {
            Console.Write("Press any key to continue!");
            Console.ReadKey();
        }
        static void TransactionHistory(ATM balance)
        {
            if(balance.transactionHistory.Count==0)
            {
                Console.WriteLine("No transaction has been made!");
            }
            else
            {
                for(int i=0;i<balance.transactionHistory.Count;i++)
                {
                    Console.WriteLine("{0}.{1}", i+1, balance.transactionHistory[i]);
                }
            }
        }
    }
}
