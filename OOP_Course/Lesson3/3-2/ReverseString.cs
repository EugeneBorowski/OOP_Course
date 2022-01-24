using System;


namespace OOP_Course.Lesson3._3_2
{
    internal class ReverseString
    {
        internal static void Start()
        {
            Console.Write("Введите строку: ");
            var str = Console.ReadLine();
            var tempstr = str.ToCharArray();
            Array.Reverse(tempstr);
            var reverseString = new string(tempstr);
            Console.WriteLine("Реверсивная строка: " + reverseString);
        }
        
    }
}
