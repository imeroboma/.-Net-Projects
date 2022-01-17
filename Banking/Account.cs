using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    public class Account
    {
        private int acctNo;
        private decimal balance;
        private static int nextNo = 100;

        //read-only public property
        public decimal Balance
        {
            get { return balance;  }
        }

        // constructor
        public Account(decimal initBalance = 0)
        {
            acctNo = nextNo;
            nextNo++;
            if (initBalance >= 0) balance = initBalance;
            else balance = 0; // default
        }

        public void Deposit(decimal amount)
        {
            if (amount < 0) amount = 0; // ignore negative
            balance += amount;
        }

        public bool Withdraw(decimal amount)
        {
            if (amount < 0) amount = 0; // ignore negative
            if (amount <= balance) // good
            {
                balance -= amount;
                return true;
            }
            else // NSF
                return false;
        }

        public override string ToString()
        {
            return acctNo.ToString() + ": " + balance.ToString("c");
        }
    }
}
