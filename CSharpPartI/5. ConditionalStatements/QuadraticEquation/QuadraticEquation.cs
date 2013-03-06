using System;

class QuadraticEquation
{
    static void Main()
    {
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());
        double discriminant = b * b - 4 * a * c;
        if (a == 0)
        {
            Console.WriteLine("There is one real root: x1 = {0}", -c / b);
        }
        else if (discriminant > 0)
        {
            double xOne = (-b + Math.Sqrt(discriminant)) / 2 * a;
            double xTwo = (-b - Math.Sqrt(discriminant)) / 2 * a;
            Console.WriteLine("There are two real roots: x1 = {0} and x2 = {1}", xOne, xTwo);
        }
        else if (discriminant == 0)
        {
            double xOne = -(b / 2 * a);
            Console.WriteLine("There is one real root: x1 = {0}", xOne);
        }
        else
        {
            Console.WriteLine("There are no real roots");
        }
    }

}
