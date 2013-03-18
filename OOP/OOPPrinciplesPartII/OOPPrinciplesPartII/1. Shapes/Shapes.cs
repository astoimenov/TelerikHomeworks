using System;

class Shapes
{
    static void Main()
    {
        Shape[] shapes = { new Rectangle(3, 4),
                             new Circle(4.3),
                             new Triangle(4, 5),
                             new Rectangle(2.3, 5),
                             new Circle(3),
                             new Triangle(5.7, 2.3)};

        foreach (Shape shape in shapes)
        {
            Console.WriteLine("{0,9} with dimensions: ({1} x {2}) and surface: {3:0.000}",
                shape.GetType().Name, shape.Width, shape.Height, shape.CalculateSurface());
        }
    }
}