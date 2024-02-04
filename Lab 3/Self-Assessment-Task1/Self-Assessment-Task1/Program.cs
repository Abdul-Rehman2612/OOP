using System;

namespace Self_Assessment_Task1
{
    internal class Program
    {
        static void Main()
        {
            Transaction transaction = new Transaction();
            transaction.ProductName = Console.ReadLine();
            Console.WriteLine(transaction.ProductName);
            Transaction trn = new Transaction(transaction);
            Console.WriteLine(trn.ProductName);
            Console.ReadKey();
        }
    }
}
