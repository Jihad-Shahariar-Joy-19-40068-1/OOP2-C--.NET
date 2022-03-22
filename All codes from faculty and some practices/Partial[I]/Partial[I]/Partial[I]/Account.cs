using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_I_
{
    partial class Account
    {
        private double balance;
        public void Deposit()
        {
            Console.WriteLine("Deposit");
            this.balance++;
        }
    }
}
