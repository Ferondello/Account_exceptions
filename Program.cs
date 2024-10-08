﻿using BankAccount.Entities;
using BankAccount.Entities.Exceptions;
namespace BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter account data: ");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Holder: ");
            string holder = Console.ReadLine();
            Console.Write("Initial balance: ");
            double balance = double.Parse(Console.ReadLine());
            Console.Write("Withdraw limit: ");
            double withdrawLimit = double.Parse(Console.ReadLine());

            Account account = new Account(number, holder, balance, withdrawLimit);
            Console.WriteLine();
            try
            {
                Console.Write("Enter amount for withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                account.Withdraw(amount);
                Console.WriteLine("New balance : "+account.Balance);
            }
            catch(DomainExceptions e)
            {
                Console.WriteLine("Error in withdraw: "+ e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexptected error: " + e.Message);
            }
        }
    }
}
