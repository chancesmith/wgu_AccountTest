using System;
using System.Collections.Generic;
using System.Text;

namespace AccountTest
{
    internal class Account
    {
        public string Name { get; set; } // auto-implemented property

        // constructor sets the Name perperty to parameter accountName's value
        public Account(string accountName) // constructor name is class name
        {
            Name = accountName;
        }

        public Account()
        {
        }
    }
}