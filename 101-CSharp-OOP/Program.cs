using System;
using System.Collections.Generic;

namespace MySuperBank
{
  class Program 
  {
    static void Main(string[] args)
    {     
      var account = new BankAccount("Saulo", 10000);
      Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance}.");
      
      account.MakeWithdrawal(120, DateTime.Now, "Hammock");
      account.MakeWithdrawal(50, DateTime.Now, "Xbox Game");

      Console.WriteLine(account.GetAccountHistory());

      // // Test for a negative balance:
      // try
      // {
      //   account.MakeWithdrawal(75000, DateTime.Now, "Attempt to overdraw");
      // }
      // catch (InvalidOperationException e)
      // {
      //   Console.WriteLine("Exception caught trying to overdraw");
      //   Console.WriteLine(e.ToString());
      // }

      // // Test that the initial balances bust be positive.
      // try
      // {
      //   var invalidAccount = new BankAccount("invalid", -55);
      // }
      // catch (ArgumentOutOfRangeException e)
      // {
      //   Console.WriteLine("Exception caught creating account with negative balance");
      //   Console.WriteLine(e.ToString());
      // }
    }

  }
}