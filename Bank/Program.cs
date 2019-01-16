using System;
using System.Collections.Generic;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankManager bankManager = new BankManager();
            bankManager.Run();
        }
    }
}