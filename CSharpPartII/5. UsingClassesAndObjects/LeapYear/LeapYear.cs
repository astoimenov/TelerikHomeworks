using System;

namespace LeapYear
{
    class LeapYear
    {
        static bool IsLeap(int year)
        {
            return year % 4 == 0 && year % 100 != 0 || year % 400 == 0;
        }

        static void Main()
        {
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine(IsLeap(year));
        }
    }
}
