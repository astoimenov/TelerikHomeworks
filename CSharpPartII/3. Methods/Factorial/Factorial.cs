using System;
using System.Numerics;

namespace Factorial
{
    class Factorial
    {
        static void Main()
        {
            int[] arr = new int[100];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i + 1;
            }
            CalculateFactorialOfN(arr);

        }
        static void CalculateFactorialOfN(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                BigInteger factorial = Fact(i);
                Console.WriteLine(factorial);
            }
        }
        static BigInteger Fact(int i)
        {
            BigInteger fact = i;
            while (i > 0)
            {
                fact *= i;
                i--;
            }
            return fact;
        }
    }
}
