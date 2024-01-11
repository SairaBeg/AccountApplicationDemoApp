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
        public Account()
        {
            MessageBox.Show("Object is created");
        }
        ~Account()
        {
            MessageBox.Show("Object is destroyed");
        }

    }
}
