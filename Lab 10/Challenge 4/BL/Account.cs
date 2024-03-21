using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge_4
{
    internal class Account
    {
        protected string Title;
        protected string AccountNumber;
        protected double  Balance;

        public Account(string title, string accountNumber, double  balance)
        {
            this.Title = title;
            this.AccountNumber = accountNumber;
            this.Balance = balance;
        }

        public  double Deposit(double  amount)
        {
           return Balance += amount;
        }

        public  double  Withdraw(double  amount)
        {
            if (amount <= Balance)
            { Balance -= amount; }
            return Balance;
               
        }
    }
}
