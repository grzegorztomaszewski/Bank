using System;
using System.Collections.Generic;
using System.Text;

namespace Bank
{
    abstract class Account
    {
        public int Id { get; }
        public string AccountNumber { get; }
        public decimal Balance { get; }
        public string FirstName { get; }
        public string LastName { get; }
        public long Pesel { get; }

        public Account(int id, string firstName, string lastName, long pesel)//konstruktor klasy SavingsAccount
        {
            Id = id;
            AccountNumber = generateAccountNumber(id);
            Balance = 0.0M;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }

        public abstract string TypeName();

        public string GetFullName()
        {
            return string.Format($"{FirstName} {LastName}");
        }

        public string GetBalance()
        {
            return string.Format($"Twoje saldo wynosi: {Balance}zł");
        }

        private string generateAccountNumber(int id)
        {
            var accountNumber =  string.Format("94{0:D10}", id);
            return accountNumber; 
        }
    } 
}
