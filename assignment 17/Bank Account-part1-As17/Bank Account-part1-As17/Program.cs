using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_part1_As17
{
    internal class Program
    {
        static void Main(string[] args)
        {
        BankAccount account = new BankAccount("78563421", "gokul rayar");

         account.Deposit(10000);

            account.Withdraw(4500);

            account.PrintAccountDetails();
        }
        
    
    }
    
}
