using PasswordProg.Tests;
using System;

namespace PasswordProg
{
    class Program
    {
        static void Main(string[] args)
        {
            string testString = "������.";
            int capitalCount = testString.CountCapitalLetters();
            Console.WriteLine($"���������� ��������� ����: {capitalCount}");
            Console.ReadKey();
        }
    }
}