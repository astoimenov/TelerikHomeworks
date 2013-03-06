using System;

class MinAndMax
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        for (int i = 1; i <= n; i++)
        {
            Console.Write("Number = ");
            int num = int.Parse(Console.ReadLine());
            if (num > max)
            {
                max = num;
            }
            if (num < min)
            {
                min = num;
            }
        }
        Console.WriteLine("Min = {0}", min);
        Console.WriteLine("Max = {0}", max);
    }
}
