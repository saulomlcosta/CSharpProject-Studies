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
    }

  }
}