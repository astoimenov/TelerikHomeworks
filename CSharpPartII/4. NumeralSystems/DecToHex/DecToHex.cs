using System;

namespace DecToHex
{
    class DecToHex
    {
        static char GetChar(int i)
        {
            if (i >= 10) return (char)('A' + i - 10);
            else return (char)('0' + i);
        }

        static string Base10ToBase16(int d)
        {
            string h = String.Empty;

            for (; d != 0; d /= 16) h = GetChar(d % 16) + h;

            return h;
        }

        static void Main()
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Base10ToBase16(num));
        }
    }
}
