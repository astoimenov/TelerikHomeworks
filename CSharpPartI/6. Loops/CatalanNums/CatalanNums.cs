using System;
using System.Numerics;

class CatalanNums
{
    static void Main()
    {
        BigInteger factorial = 1, factorial2 = 1, result;
        Console.Write("Please enter your number: ");
        int n = int.Parse(Console.ReadLine());
        for (int i = 1, j = (n + 1); i <= n; i++, j++)
        {
            factorial *= i;
            factorial2 *= j;
        }
        result = (factorial2 * factorial) / (((n + 1) * factorial) * factorial);
        Console.WriteLine("The Catalan numbers is: {0}", result);
    }
}
