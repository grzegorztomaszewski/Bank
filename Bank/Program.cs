﻿using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nazwa: Bank";
            string author = "Autor: Marek Zajac";
            Console.WriteLine(name);
            Console.WriteLine(author);
            Console.WriteLine();

            SavingsAccount savingsAccount = new SavingsAccount("940000000001", 0.0M, "Marek", "Zając", 92010133333);
            
            SavingsAccount secondSavingsAccount = new SavingsAccount("940000000002", 0.0M, "Marek", "Zając", 92010133333);

            BillingAccount billingAccount = new BillingAccount("940000000003", 0.0M, "Marek", "Zając", 92010133333);

            string fullName = savingsAccount.GetFullName();
            Console.WriteLine($"Pierwsze konto oszczędnościowe w systemie dodał/a: {fullName}");

            Printer printer = new Printer();

            printer.Print(savingsAccount);
            printer.Print(secondSavingsAccount);

            string fullName2 = billingAccount.GetFullName();
            Console.WriteLine($"Pierwsze konto rozliczeniowe w systemie dodał/a: {fullName2}");

            printer.Print(billingAccount);

            Console.ReadKey();
        }
    }
}