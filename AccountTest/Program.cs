using System;

namespace AccountTest
{
    internal class AccountTest
    {
        private static void Main(string[] args)
        {
            // create an Account object and assign it to myAccount
            Account myAccount = new Account("Chance");

            // display myAccount's initial name (there isn't one yet)
            Console.WriteLine($"Initial name is {myAccount.Name}");

            // prompt for and read the name, then put the name in the object
            Console.Write("Enter the name: "); // prompt
            string theName = Console.ReadLine(); // read the name
            myAccount.Name = theName; // put theName in the myAccount object

            // display the name stored in the myAccount object
            Console.WriteLine($"You are viewing account: {myAccount.Name}");
        }
    }
}