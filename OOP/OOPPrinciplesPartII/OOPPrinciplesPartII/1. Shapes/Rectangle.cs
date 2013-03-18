using System;

class Rectangle : Shape
{
    // Constructor
    public Rectangle()
        : this(0, 0) { }

    public Rectangle(double width, double height)
        : base(width, height) { }

    // Methods
    public override double CalculateSurface()
    {
        return this.Height * this.Width;
    }
}