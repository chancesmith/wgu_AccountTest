using System;
using System.Collections.Generic;
using System.Text;

namespace AccountTest
{
    internal class Account
    {
        public string Name { get; set; } // auto-implemented property
        private decimal balance; // instance variable

        // Account constructor that revieves two parameters
        public Account(string accountName, decimal initialBalance) // constructor name is class name
        {
            Name = accountName;
            Balance = initialBalance; // Balance's set accessor validates
        }

        // Balance property with validation public devimal Balance
        public decimal Balance
        {
            get { return balance; }
            private set // can be used only with the class
            {
                // validate that the balance is greater than 0.0; if it's not,
                // instance variable balance keeps it's prior value
                if (value > 0.0m) // m indeicates that 0.0 is a decimal literal
                {
                    balance = value;
                }
            }
        }

        // method that deposits (adds) only a valid amount to the balance
        public void Deposit(decimal depositAmount)
        {
            if (depositAmount > 0.0m) // if the depositAmount is valid
            {
                Balance = Balance + depositAmount; // add it to the balance
            }
        }
    }
}