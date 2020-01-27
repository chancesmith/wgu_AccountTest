using System;
using System.Collections.Generic;
using System.Text;

namespace AccountTest
{
    internal class Account
    {
        private string name; // instance variable

        public string Name
        {
            get // returns the corresponding instance variable's value
            {
                return name;
            }
            set // assigns a new value to the corresponding instace variable
            {
                name = value; // value is implicitly declared and initialized
            }
        }
    }
}