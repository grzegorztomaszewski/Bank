using System;

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

            SavingsAccount savingsAccount = new SavingsAccount(1, "Marek", "Zając", 92010133333);
            
            SavingsAccount secondSavingsAccount = new SavingsAccount(2,"Marek", "Zając", 92010133333);

            Account billingAccount = new BillingAccount(3, "Marek", "Zając", 92010133333);

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