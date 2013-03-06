using System;

namespace FindMaxSum
{
    class FindMaxSum
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;
            int pos = 0;
            int[] a = new int[n];
            for (int i = 0; i < n; i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i <= n - k; i++)
            {
                for (int j = i; j < i + k; j++)
                {
                    sum += a[j];
                }
                if (sum > max)
                {
                    max = sum;
                    pos = i;
                }
                sum = 0;
            }
            for (int i = pos; i < pos + k; i++)
            {
                Console.WriteLine(a[i] + " ");
            }        
        }
    }
}
