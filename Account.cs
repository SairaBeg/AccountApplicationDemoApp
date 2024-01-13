using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountApplicationDemoApp
{
    public class Account
    {
        private int _Id;
        private string _Name;
        private decimal _Balance;

        private bool _IdAlreadySet;

        public string Address { get; set; }
        public int Id { get { return _Id; }
            set
            {
                if (_IdAlreadySet)
                    throw new ApplicationException("Id is already set");
                _Id = value;
                _IdAlreadySet = true;
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }
            set
            {
                if (value.Length > 8)
                {
                    throw new ApplicationException("Name cannot be more than 8 characters");
                }
                _Name = value;
            }
        }
        public decimal Balance
        {
            get { return _Balance; }
            //set {_Balance = value; } 
        }
        public void Deposit(decimal amount)
        {
            this._Balance += amount;
        }
        public void Withdraw(decimal withdrawlAmt)
        {
            if (this.Balance-withdrawlAmt < 500) {
                throw new ApplicationException("Insufficient funds");
            }
            else
            {
                this._Balance-= withdrawlAmt;
            }
        }

    }
}

