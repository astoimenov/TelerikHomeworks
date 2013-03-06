using System;

class CheckIfPointIsWithinCircle
{
    static void Main()
    {
        int xCircle = 0;
        int yCircle = 0;
        Console.WriteLine("Enter a value for x: ");
        int xPoint = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for y: ");
        int yPoint = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a value for radius: ");
        int radius = int.Parse(Console.ReadLine());
        bool result = ((xPoint - xCircle) * (xPoint - xCircle)) + ((yPoint - yCircle) * (yPoint - yCircle)) <= (radius * radius);
        if (result == true)
        {
            Console.WriteLine("The point ({0}, {1}) is whitin the circle", xPoint, yPoint);
        }
        else
        {
            Console.WriteLine("The point ({0}, {1}) isn`t within the circle", xPoint, yPoint);
        }
    }
}
