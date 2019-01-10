using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Printer
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
}
