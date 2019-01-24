using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts.Entitites
{
    class SavingsAccount : Account
    {
        public double InterestRate { get; set; }
        // construtores
        public SavingsAccount()
        {

        }
        public SavingsAccount(int number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = InterestRate;
        }

        // funcoes
        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public sealed override void Withdraw(double amount)
        {
            Balance -= amount;
        }
    }
}
