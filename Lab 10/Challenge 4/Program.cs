using Challenge_4.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StundentAccount student = new StundentAccount("John Doe", "123456", 10000);
            Console.WriteLine(student.Deposit(5000));
            Console.WriteLine(student.Withdraw(7000)); 
            SalaryAccount salary = new SalaryAccount("Jane Smith", "789012", 20000);
            Console.WriteLine(salary.Deposit(10000));
            Console.WriteLine(salary.Withdraw(30000)); 

            SavingAccount savings = new SavingAccount("Alice Johnson", "345678", 50000);
            double interest = savings.CalculateInterest();
            Console.WriteLine(interest);

            Console.ReadLine();
        }
    }
}
