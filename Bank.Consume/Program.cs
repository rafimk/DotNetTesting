using Bank.Lib;
using System;

namespace Bank.Consume
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(1000);
            account.Add(100);

            Console.WriteLine($"Your balance is {account.Balance.ToString()} ");
        }
    }
}
