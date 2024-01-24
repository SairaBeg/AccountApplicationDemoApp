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

        public static int MinBalance = 500;

        static Account()
        {
            //Place for initialization of all static class memebers
            System.Windows.Forms.MessageBox.Show("Class is loaded via static constructor");
        }

        //Parameterless constructor/Default constructor
        public Account()
        {
            
        }
        //Parametized constructor
        public Account(int id, string name, decimal balance):this()
        {
            this.Id = id;
            this.Name = name;
            this.Balance = balance;
        }
        //Copy constructor
        public Account(Account a):this(a._Id,a._Name,a._Balance)
        {
            //this.Id = a.Id;
            //this.Name = a.Name;
            //this.Balance = a.Balance;
        }
        //Destructor 
        ~Account()
        {

        }
        private bool _IdAlreadySet;
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
          set {_Balance = value; } 
        }
        public void Deposit(decimal amount)
        {
            this._Balance += amount;
        }
        public void Withdraw(decimal withdrawlAmt)
        {
            if (this.Balance-withdrawlAmt < MinBalance) {
                throw new ApplicationException("Insufficient funds");
            }
            else
            {
                this._Balance-= withdrawlAmt;
            }
        }

    }
}

