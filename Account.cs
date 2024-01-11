using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApplicationDemoApp
{
    public class Account
    {
        public int Id;
        public string Name;
        public decimal Balance;

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }
        public void Withdraw(decimal withdrawlAmt)
        {
            if (this.Balance-withdrawlAmt < 500) {
                throw new ApplicationException("Insufficient funds");
            }
            else
            {
                this.Balance-= withdrawlAmt;
            }
        }

    }
}
