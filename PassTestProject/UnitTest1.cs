using PasswordProg.Tests;
using System;

namespace PasswordProg
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "Привет.";
            int capitalCount = testString.CountCapitalLetters();
            Console.WriteLine($"Количество заглавных букв: {capitalCount}");
            Console.ReadKey();
        }
    }
}