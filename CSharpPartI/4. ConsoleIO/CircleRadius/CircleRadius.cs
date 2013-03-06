using System;

class CircleRadius
{
    static void Main()
    {
        Console.Write("Enter radius: ");
        int rad = int.Parse(Console.ReadLine());
        double area = Math.PI * rad * rad;
        double perimeter = 2 * Math.PI * rad;
        Console.WriteLine("The circle`s area is: {0}", area);
        Console.WriteLine("The circle`s perimeter is: {0}", perimeter);
    }
}
