using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Self_Assessment_Task3
{
    internal class ATM
    {
        public double balance;
        public List<string> transactionHistory=new List<string>();
        public ATM()
        {
            this.balance=2000000;
        }
        public void DepositMoney(double amount)
        {
            balance+=amount;
            AddTransaction($"Rs.{amount} deposited to the account!");
        }
        public void WithDrawMoney(double amount)
        {
            balance-=amount;
            AddTransaction($"Rs.{amount} withdrawn from the account!");
        }
        public void AddTransaction(string t)
        {
            transactionHistory.Add(t);
        }
    }
}
