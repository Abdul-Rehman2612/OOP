using System;

namespace Challenge_4.BL
{
    internal class StundentAccount : Account
    {

        public const Double MaxCreditLimit = 500000;

        public StundentAccount(string title, string accountNumber, double balance) : base(title, accountNumber, balance)
        {

        }

        public double WithdrawStudent(double amount)
        {
            if (amount <= Balance)
            { Balance -= amount; }
            return Balance;
        }
        public double DepositStudent(double amount)
        {
            if (amount <= Balance + MaxCreditLimit) {
            Balance += amount;
            }
            return Balance;
        }

    }
}
