using System;

class SumOfN
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        int sum = 0;
        Console.WriteLine();

        for (int i = 0; i < n ; i++)
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            sum += number;
        }
        Console.WriteLine("Sum = {0}", sum);
    }
}
