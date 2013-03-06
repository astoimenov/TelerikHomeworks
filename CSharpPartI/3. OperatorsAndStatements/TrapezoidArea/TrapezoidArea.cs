using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter  correct values for a, b and h of trapezoid [ a>=0, b>=0, h>=0 ])");
        Console.WriteLine("Enter a: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter b: ");
        int b = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter h: ");
        int h = int.Parse(Console.ReadLine());
        if (a >= 0 && b >= 0 && h >= 0)
        {
            int area = (a + b) / 2 * h;
            Console.WriteLine("The area of the trapezoid is {0}", area);
        }
        else
        {
            Console.WriteLine("The entered values of a, b and/or h are invalid!");
        }
    }
}
