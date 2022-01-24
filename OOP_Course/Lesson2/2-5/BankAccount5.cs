﻿using System;

namespace OOP_Course.Lesson2._2_5
{
    public class BankAccount5
    {
        private static int _id;
        private int _accountId;
        private decimal _balance = 0;
        internal enum AccountType
        {
            Дебетовый,
            Кредитный,
            Сберегательный
        };
        private AccountType _accountType;

        internal BankAccount5()
        {
            GenerateAccountId();
        }

        internal BankAccount5(decimal balance) : this()
        {
            _balance = balance;
        }

        internal BankAccount5(AccountType accountType) : this()
        {
            _accountType = accountType;
        }
        internal BankAccount5(decimal balance, AccountType accountType) : this()
        {
            _balance = balance;
            _accountType = accountType;
        }

        internal int SetBalance
        {
            set
            {
                this._balance = value;
            }
        }

        internal int SetAccountType
        {
            set
            {
                this._accountType = (AccountType)value;
            }
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

        internal void Deposit(int sum)
        {
            _balance += sum;
        }

        internal void Withdraw(int sum)
        {
            if (sum <= _balance)
                _balance -= sum;
            else
                Console.WriteLine("Недостаточно средств для изъятия");
        }
    }
}