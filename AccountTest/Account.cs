using System;
using System.Collections.Generic;
using System.Text;

namespace AccountTest
{
    internal class Account
    {
        private string name; // instance variable

        // method that set the account name in the object
        public void SetName(string accountName)
        {
            name = accountName; // store the account name
        }

        // method that retrieves the account name from the object
        public string GetName()
        {
            return name; // returns name's value to this method's caller
        }
    }
}