using System;
using System.Numerics;

class FibonacciSequence
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        BigInteger tempSum = 0;
        BigInteger first = 0;
        BigInteger second = 1;
        BigInteger totalSum = 0;
        if (n == 0 || n == 1)
        {
            Console.WriteLine(0);
        }
        else
        {
            for (int i = 0; i < (n - 2); i++)
            {
                tempSum = first + second;
                first = second;
                second = tempSum;
                totalSum += tempSum;
            }
            totalSum++;
            Console.WriteLine("Sum = " + totalSum);
        }

    }


}
