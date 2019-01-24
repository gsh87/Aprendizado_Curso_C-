using System;
using System.Collections.Generic;
using System.Text;

namespace Accounts.Entitites
{
    class BusinessAccount:Account
    {
        public double  LoamLimit { get; set; }
        public BusinessAccount()
        {
        }
public BusinessAccount(int number, string holder, double balance,double loamLimit): base(number,holder,balance)
        {
            LoamLimit = loamLimit;
        }

        public void Loam(double amount)
        {
            if(amount<=LoamLimit)
            {
                Balance = +amount;
            }
        }

    }
}
