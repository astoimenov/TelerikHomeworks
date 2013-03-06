using System;

class NumbersFromOneToN
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine();
        int i = 1;
        do
        {
            Console.WriteLine(i);
            i++;
        } while (i <= n);
    }
}
