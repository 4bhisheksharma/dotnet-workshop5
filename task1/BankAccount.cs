using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class BankAccount
    {
        private int accountNumber;
        private double balance;

        public int AccountNumber
        {
            get { return accountNumber; }

        }

        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value < 0)
                {
                    balance = value;
                }
                else
                {
                   Console.WriteLine("Initial balance cannot be negative.");
                }
            }
        }

        public BankAccount(int accountNumber, double initialBalance)
        {
            this.accountNumber = accountNumber;
            Balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be positive.");
            }
            else
            {
                balance += amount;
                Console.WriteLine("Deposit successful. New balance: " + balance);
            }
        }

        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdrawal amount must be positive.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds for this withdrawal.");
            }
            else{
                balance -= amount;
                Console.WriteLine("Withdrawal successful. New balance: " + balance);
            }
        }
    }

}
