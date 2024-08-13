using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using BankAccount.Entities.Exceptions;

namespace BankAccount.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double WithdrawLimit { get; set; }
        public Account() { }    
        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }
        public void deposit(double amount)
        {

            Balance += amount;

        }
        public void Withdraw(double amount)
        {
            if(amount > WithdrawLimit)
            {
                throw new DomainExceptions("Withdraw amount must be smaller than your limit");
            }
            if(amount > Balance)
            {
                throw new DomainExceptions("Withdraw amount must be smaller than you balance");
            }
            Balance -= amount;
        }
    }
}
