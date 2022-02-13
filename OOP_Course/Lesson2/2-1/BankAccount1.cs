using System;

namespace OOP_Course.Lesson2._2_1
{
    public class BankAccount1
    {
        private int _accountId;
        private decimal _balance;
        internal enum AccountType
        {
            Дебетовый,
            Кредитный,
            Сберегательный
        };
        private AccountType _accountType;

        internal void FillAccount(decimal balance, AccountType accountType, int accountId)
        {
            _balance = balance;
            _accountType = accountType;
            _accountId = accountId;
        }

        internal void PrintAccountDetails()
        {
            Console.WriteLine("Информация о счете:");
            Console.WriteLine("Номер счета: " + _accountId);
            Console.WriteLine("Баланс: " + _balance);
            Console.WriteLine("Тип счета: " + _accountType);
        }

    }
}
