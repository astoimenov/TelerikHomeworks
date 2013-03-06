using System;

namespace BiggerNumber
{
    class BiggerNumber
    {
        static int GetMax(int x, int y)
        {
            return x > y ? x : y;
        }

        static void Main()
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b = ");
            int b = int.Parse(Console.ReadLine());
            Console.Write("c = ");
            int c = int.Parse(Console.ReadLine());

            Console.WriteLine(GetMax(GetMax(a, b), c));
        }
    }
}
