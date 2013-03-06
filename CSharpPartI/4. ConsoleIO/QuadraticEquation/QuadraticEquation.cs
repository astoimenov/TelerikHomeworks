using System;
using System.Text;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a: ");
        int a = int.Parse(Console.ReadLine());
        Console.Write("b: ");
        int b = int.Parse(Console.ReadLine());
        Console.Write("c: ");
        int c = int.Parse(Console.ReadLine());

        if (a == 0)
        {
            Console.WriteLine("This is not a quadratic equation!");
        }
        else
        {
            int discriminant = b * b - (4 * a * c);
            if (discriminant < 0)
            {
                Console.WriteLine("The equation doesn`t have real roots!");
            }
            else if (discriminant == 0)
            {
                int x = -b / (2 * a);
                Console.WriteLine("The root of the equation is: x = {0}", x);
            }
            else
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("The roots of the equation are:");
                Console.WriteLine("x1 = {0}", x1);
                Console.WriteLine("x2 = {0}", x2);
            }
        }
    }
}
