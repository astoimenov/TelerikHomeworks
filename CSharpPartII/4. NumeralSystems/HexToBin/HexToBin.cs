using System;

namespace HexToBin
{
    class HexToBin
    {
        static int GetNumber(string s, int i)
        {
            if (s[i] >= 'A') return s[i] - 'A' + 10;
            else return s[i] - '0';
        }

        static string Base16ToBase2(string h)
        {
            string b = String.Empty;

            for (int i = h.Length - 1; i >= 0; i--)
                for (int j = 0, d = GetNumber(h, i); j < 4; j++, d /= 2) // 2 ^ 4 = 16
                    b = d % 2 + b;

            return b;
        }

        static void Main()
        {
            string num = Console.ReadLine();
            Console.WriteLine(Base16ToBase2(num));
        }
    }
}
