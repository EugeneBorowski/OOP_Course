using System;

namespace OOP_Course.Lesson3._3_1
{
    public class BankAccount31
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

        internal BankAccount31()
        {
            GenerateAccountId();
        }

        internal BankAccount31(decimal balance) : this()
        {
            _balance = balance;
        }

        internal BankAccount31(AccountType accountType) : this()
        {
            _accountType = accountType;
        }
        internal BankAccount31(decimal balance, AccountType accountType) : this()
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
        internal void Transfer(BankAccount31 account, int sum)
        {
            if (sum <= account._balance)
                _balance += sum;
            else
                Console.WriteLine("Недостаточно средств для перевода");
        }
    }
}