﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class SavingsAccount
    {
        public string AccountNumber;
        public decimal Balance;
        public string FirstName;
        public string LastName;
        public long Pesel;


        public SavingsAccount(string accountNumber, decimal balance, string firstName, string lastName, long pesel)//konstruktor klasy SavingsAccount
        {
            AccountNumber = accountNumber;
            Balance = balance;
            FirstName = firstName;
            LastName = lastName;
            Pesel = pesel;
        }

        public string GetFullName()
        {
            return string.Format($"{FirstName} {LastName}");
        }

        public string GetBalance()
        {
            return string.Format($"Twoje saldo wynosi: {Balance}zł");
        }
    }
}
