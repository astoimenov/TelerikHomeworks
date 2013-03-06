using System;

namespace LastDigitInEnglish
{
    class LastDigitInEnglish
    {
        static string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

        static string GetDigitName(int n)
        {
            return digitNames[n];
        }

        static int GetLastDigit(int n)
        {
            return n % 10;
        }

        static void Main()
        {
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(GetDigitName(GetLastDigit(number)));
        }
    }
}
