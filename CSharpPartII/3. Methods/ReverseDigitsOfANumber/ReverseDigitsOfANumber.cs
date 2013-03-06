using System;
using System.Text;

namespace ReverseDigitsOfANumber
{
    class ReverseDigitsOfANumber
    {
        static string ReverseNumber(int num)
        {
            StringBuilder reverseNumber = new StringBuilder();
            while (num != 0)
            {
                int lastDigit = num % 10;
                int lastNumber = num / 10;
                num = lastNumber;

                reverseNumber.Append(lastDigit);
            }

            return reverseNumber.ToString();
        }

        static void Main()
        {
            Console.Write("Number = ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(ReverseNumber(n));
        }
    }
}
