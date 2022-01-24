using System;

namespace OOP_Course.Lesson2._2_4
{
    public class BankAccount4
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

        internal BankAccount4()
        {
            GenerateAccountId();
        }

        internal BankAccount4(decimal balance) : this()
        {
            _balance = balance;
        }

        internal BankAccount4(AccountType accountType) : this()
        {
            _accountType = accountType;
        }
        internal BankAccount4(decimal balance, AccountType accountType) : this()
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
    }
}