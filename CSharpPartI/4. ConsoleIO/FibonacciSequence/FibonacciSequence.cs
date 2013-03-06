using System;

class FibonacciSequence
{
    static void Main()
    {
        decimal a = 0, b = 1, c = 0;
        Console.WriteLine(a);
        Console.WriteLine(b);
        for (int i = 0; i <= 98 ; i++)
        {
            c = a + b;
            Console.WriteLine(c);
            a = b;
            b = c;
        }
    }
}
