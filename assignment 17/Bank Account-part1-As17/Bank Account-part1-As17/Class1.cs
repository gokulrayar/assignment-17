using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Account_part1_As17
{
    internal class BankAccount
    {
       
            string AccountNumber { get; }
            string AccountHolderName { get; set; }
            decimal Balance { get; set; }
            public BankAccount(string accountNumber, string accountHolderName)
            {
                AccountNumber = accountNumber;
                AccountHolderName = accountHolderName;
                Balance = 0;
            }

            
            public void Deposit(decimal amount)
            {
                Balance += amount;
            }

            public void Withdraw(decimal amount)
            {
                Balance -= amount;
            }

            public void PrintAccountDetails()
            {
                Console.WriteLine($"Account Number: {AccountNumber}");
                Console.WriteLine($"Account Holder Name: {AccountHolderName}");
                Console.WriteLine($"Balance: {Balance}");
               

            Console.ReadKey();
            }
             
        }
}
