using System;
using OOP_Course.Lesson2._2_1;
using OOP_Course.Lesson2._2_2;
using OOP_Course.Lesson2._2_3;
using OOP_Course.Lesson2._2_4;
using OOP_Course.Lesson2._2_5;
using OOP_Course.Lesson3._3_1;
using OOP_Course.Lesson3._3_2;


namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //StartLesson2();
            StartLesson3();




        }

        static void StartLesson2()
        {
            //2 - 1
            Console.WriteLine("Урок 2-1");
            var account1 = new BankAccount1();
            account1.FillAccount(10, BankAccount1.AccountType.Дебетовый, 1);
            account1.PrintAccountDetails();
            Console.ReadLine();
            //2 - 2
            Console.WriteLine("Урок 2-2");
            var account2 = new BankAccount2();
            account2.FillAccount(10, BankAccount2.AccountType.Дебетовый);
            account2.PrintAccountDetails();
            var account21 = new BankAccount2();
            account21.FillAccount(20, BankAccount2.AccountType.Дебетовый);
            account21.PrintAccountDetails();
            Console.ReadLine();
            //2 - 3
            Console.WriteLine("Урок 2-3");
            var account3 = new BankAccount3(20);
            var account31 = new BankAccount3(BankAccount3.AccountType.Сберегательный);
            var account32 = new BankAccount3(30, BankAccount3.AccountType.Дебетовый);
            account3.PrintAccountDetails();
            account31.PrintAccountDetails();
            account32.PrintAccountDetails();
            Console.ReadLine();
            //2 - 4
            Console.WriteLine("Урок 2-4");
            var account4 = new BankAccount4(20);
            var account41 = new BankAccount4(BankAccount4.AccountType.Сберегательный);
            var account42 = new BankAccount4(30, BankAccount4.AccountType.Дебетовый);
            account4.PrintAccountDetails();
            account41.PrintAccountDetails();
            account42.PrintAccountDetails();
            account4.SetBalance = 50;
            account41.SetAccountType = (int)BankAccount4.AccountType.Кредитный;
            account4.PrintAccountDetails();
            account41.PrintAccountDetails();
            Console.ReadLine();
            //2 - 5
            Console.WriteLine("Урок 2-5");
            var account5 = new BankAccount5(20);
            account5.Deposit(50);
            account5.PrintAccountDetails();
            account5.Withdraw(30);
            account5.PrintAccountDetails();
            Console.ReadLine();
        }

        static void StartLesson3()
        {
            var account311 = new BankAccount31(20);
            var account312 = new BankAccount31(20);

            ReverseString.Start();
        }
    }
}
