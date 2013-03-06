using System;

namespace BinaryRepresentation
{
    class BinaryRepresentation
    {
        static string GetBinary(short s)
        {
            string b = String.Empty;

            for (int i = 0; i < 16; i++) b = (s >> i & 1) + b;

            return b;
        }

        static void Main()
        {
            short num = short.Parse(Console.ReadLine());
            Console.WriteLine(GetBinary(num));
        }
    }
}
