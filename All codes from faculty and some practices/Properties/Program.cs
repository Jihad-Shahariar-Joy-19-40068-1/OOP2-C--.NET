﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Properties;

namespace Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account();
            account.AccountNumber = 10101;
            account.AccountName = "ABC";
            account.Balance = 2000;
            //account.PrintAccountDetails();
            account.Withdraw();

            Console.ReadKey();
        }
    }
}
