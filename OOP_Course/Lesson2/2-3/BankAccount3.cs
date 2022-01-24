using System;

namespace OOP_Course.Lesson2._2_3
{
    public class BankAccount3
    {
        private static int _id;
        private int _accountId;
        private decimal _balance;
        internal enum AccountType
        {
            Дебетовый,
            Кредитный,
            Сберегательный
        };
        private AccountType _accountType;

        internal BankAccount3()
        {
            GenerateAccountId();
            _balance = 0;
        }

        internal BankAccount3(decimal balance)
        {
            GenerateAccountId();
            _balance = balance;
        }
        internal BankAccount3(AccountType accountType)
        {
            GenerateAccountId();
            _balance = 0;
            _accountType = accountType;
        }
        internal BankAccount3(decimal balance,AccountType accountType)
        {
            GenerateAccountId();
            _balance = balance;
            _accountType = accountType;
        }

        internal void SetBalance(decimal balance)
        {
            _balance = balance;
        }
        internal void SetAccountType(AccountType accountType)
        {
            _accountType = accountType;
        }

        internal void PrintAccountDetails()
        {
            Console.WriteLine("Информация о счете:");
            Console.WriteLine("Номер счета: " + _accountId);
            Console.WriteLine("Баланс: " + _balance);
            Console.WriteLine("Тип счета: " + _accountType);
        }
        private void GenerateAccountId()
        {
            _accountId = ++_id;
        }
    }
}