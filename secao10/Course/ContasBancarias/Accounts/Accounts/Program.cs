using System;
using Accounts.Entitites;
using System.Globalization;

namespace Accounts
{
    class Program
    {
        static void Main(string[] args)
        {
            //  UPCASTING e DOWNCASTING
            /*
            Account acc = new Account(1001, "Alex", 0.00);
            BusinessAccount bacc = new BusinessAccount(1002, "Maria", 0.00, 500.00);

            /// upcasting
            /// 
            Account acc1 = bacc;
            Account acc2 = new BusinessAccount(1003, "Jao", 500.00, 0.00);
            Account acc3 = new SavingsAccount(1004, "Ana", 250.00, 0.001);

            /// downcasting
            BusinessAccount acc4 = (BusinessAccount)acc2;
            acc4.Loam(100.00);
            if(acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
                acc5.Loam(200.00);
                Console.WriteLine("Loam! ");

            } 
            if( acc3 is SavingsAccount)
            {
                SavingsAccount acc5 = (SavingsAccount)acc3;
                acc5.UpdateBalance();
                Console.WriteLine("update!");
            }

            */

            //// palavras virutal override e sobrecargas

            Account acc1 = new Account(1001, "Alex", 500.00);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.00, 0.01);
            acc1.Withdraw(10.00);
            acc2.Withdraw(10.00);
            Console.WriteLine("acc1: "+acc1.Balance);
            Console.WriteLine("ac22: "+acc2.Balance);

        }
    }
}
