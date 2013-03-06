using System;

class SumOfFactoriels
{
    static void Main()
    {
        Console.Write("n = ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("x = ");
        int x = int.Parse(Console.ReadLine());
        decimal sum = 1;
        decimal fact = 1;
        decimal exp = 1;
        for (int i = 1; i <= n; i++)
        {
            exp *= x;
            fact *= i;
            sum += (fact / exp);
        }

        Console.WriteLine("Sum(n!)/(x^n) = {0}", sum);

    }

}
