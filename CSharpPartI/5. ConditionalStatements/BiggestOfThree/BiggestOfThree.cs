using System;

class BiggestOfThree
{
    static void Main()
    {
        Console.Write("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("Enter c: ");
        int c = int.Parse(Console.ReadLine());

        if (a > b)
        {
            if (c > a)
            {
                Console.WriteLine("The biggest number is {0}!", c);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}!", a);
            }
        }
        else
        {
            if (b > c)
            {
                Console.WriteLine("The biggest number is {0}!", b);
            }
            else
            {
                Console.WriteLine("The biggest number is {0}!", c);
            }
        }
    }
}
