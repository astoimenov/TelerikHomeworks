using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Vavedete width>0: ");
        string widthStr = Console.ReadLine();
        uint width = uint.Parse(widthStr);
        Console.WriteLine("Vavedete height>0: ");
        string heightStr = Console.ReadLine();
        uint height = uint.Parse(heightStr);
        uint rectArea = width * height;
        Console.WriteLine("The area of the rectangle is {0}", rectArea);
    }
}
