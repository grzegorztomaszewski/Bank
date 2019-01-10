using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Printer
    {
        public void Print (SavingsAccount account)
        {
            Console.WriteLine($"Dane konta: {account.AccountNumber}");
            Console.WriteLine($"Saldo: {account.Balance}");
            Console.WriteLine($"Imię właściciela: {account.FirstName}");
            Console.WriteLine($"Nazwisko właściciela: {account.LastName}");
            Console.WriteLine($"PESEL właściciela: {account.Pesel}");
            Console.WriteLine(account.GetBalance());
            Console.WriteLine();
        }
        public void Print(BillingAccount account)
        {
            Console.WriteLine($"Dane konta: {account.AccountNumber}");
            Console.WriteLine($"Saldo: {account.Balance}");
            Console.WriteLine($"Imię właściciela: {account.FirstName}");
            Console.WriteLine($"Nazwisko właściciela: {account.LastName}");
            Console.WriteLine($"PESEL właściciela: {account.Pesel}");
            Console.WriteLine(account.GetBalance());
            Console.WriteLine();
        }
    }
}
