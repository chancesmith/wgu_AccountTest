using System;

namespace AccountTest
{
    internal class AccountTest
    {
        private static void Main(string[] args)
        {
            Account myAccount = new Account();
            myAccount.SetName("Chance-100");
            Console.WriteLine($"You are viewing account: {myAccount.GetName()}");
        }
    }
}