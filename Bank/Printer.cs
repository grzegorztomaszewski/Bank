using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Printer : IPrinter
    {
        public void Print (Account account)
        {
            Console.WriteLine($"Dane konta: {account.AccountNumber}");
            Console.WriteLine($"Typ konta: {account.TypeName()}");
            Console.WriteLine(account.GetBalance());
            Console.WriteLine($"Imię i nazwisko właściciela: {account.GetFullName()}");
            Console.WriteLine($"PESEL właściciela: {account.Pesel}");
            Console.WriteLine();
        }
    }
    class SmallerPrinter : IPrinter
    {
        public void Print(Account account)
        {
            Console.WriteLine($"Dane konta: {account.AccountNumber}");
            Console.WriteLine($"Imię i nazwisko właściciela: {account.GetFullName()}");
        }
    }
}
