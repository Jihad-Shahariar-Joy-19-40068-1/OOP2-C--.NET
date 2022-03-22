using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class Account
    {
        //Field Declaration
        private int accountNumber;
        private string accountName;
        private double balance;

        //Property declaration
        public int AccountNumber
        {
            set { this.accountNumber = value; }
            get { return this.accountNumber; }
        }

        public string AccountName
        {
            set { this.accountName = value; }
            get { return this.accountName; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public void Withdraw(double amount)
        {
            if (amount < this.balance && amount > 0)
            {
                this.balance -= amount;
                Console.WriteLine(+amount + " was deducted from account " + this.accountNumber + ". New balance is : " + this.balance);
            }
            else
            {
                Console.WriteLine("Insuffiecient balance");
            }
        }

        public void Deposite(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                Console.WriteLine(+ amount +" was added to account" + this.accountNumber+ ". New balance is : " + this.balance);
            }
            else
            {
                Console.WriteLine("Enter amount properly");
            }
        }

        public void Transfer(Account receiver, double amount)
        {
            receiver.Deposite(amount);
            this.Withdraw(amount);
            Console.WriteLine("Transfer complete");
        }

    }
}
