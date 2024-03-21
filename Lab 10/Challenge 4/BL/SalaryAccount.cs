using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    internal class SalaryAccount :Account
    {
        public SalaryAccount(string title, string accountNumber, double balance)   : base(title, accountNumber, balance)
        {

        }
        public double WithdrawSalary(double amount)
        {
            if (amount <= Balance)
            { Balance -= amount; }
            return Balance;
        }
        public double DepositSalary(double amount)
        {
           
                Balance += amount;
            
            return Balance;
        }
    }
}
