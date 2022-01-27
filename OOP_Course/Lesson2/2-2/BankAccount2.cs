using System;

namespace OOP_Course.Lesson2._2_2
{
    public class BankAccount2
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

        internal void FillAccount(decimal balance, AccountType accountType)
        {
            _balance = balance;
            _accountType = accountType;
            GenerateAccountId();
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