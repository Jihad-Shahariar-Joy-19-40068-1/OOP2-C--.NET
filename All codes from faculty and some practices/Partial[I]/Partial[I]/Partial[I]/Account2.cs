using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partial_I_
{
    partial class Account
    {
        public void Withdraw()
        {
            Console.WriteLine("Withdraw");
            this.balance++;
        }
        public void Deposit(int i)
        {
            Console.WriteLine("Deposit");
        }
    }
}
