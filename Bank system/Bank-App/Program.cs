using System;
using System.Collections.Generic;

namespace Bank
{
    class program
    {
        static void Main(string[] args)
        {
            enumclass bankday=new enumclass();
            bankday.activedays();

            BankAccount bankac=new BankAccount(0.00,"debmalya");
            bankac.Getinfo();
            BankAccount bankceo=new BankAccount(0,"ceo");
            bankac.Deposit(650);
            bankac.Getinfo();

            bankac.Withdraw(300);
            bankac.Getinfo();

            bankac.Getinfo();
        }
    }
}

  