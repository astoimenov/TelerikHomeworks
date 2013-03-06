using System;

class MultiplicationFactorials
{
    static void Main()
    {
        Console.Write("Enter number for N: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter number for K: ");
        int k = int.Parse(Console.ReadLine());
        decimal factorialN = 1;
        decimal factorialK = 1;
        decimal factorialSub = 1;
        if (1 < n && 1 < k && n < k)
        {
            for (int i = n; i >= 1; i--)
            {
                factorialN *= i;

            }
            for (int i = k; i >= 1; i--)
            {
                factorialK *= i;

            }
            for (int i = (k - n); i >= 1; i--)
            {
                factorialSub *= i;
            }
            decimal result = (factorialN * factorialK) / factorialSub;
            Console.WriteLine("N!:{0}, K!:{1} calculation of N!*K! / (K-N)! is: {2}", factorialN, factorialK, result);
        }
        else
        {
            Console.WriteLine("Please enter two numbers greater than one and N < K");
        }
    }
}
