using System;

class Triangle : Shape
{
    // Constructor
    public Triangle()
        : this(0, 0) { }

    public Triangle(double width, double height)
        : base(width, height) { }

    // Methods
    public override double CalculateSurface()
    {
        return (this.Height * this.Width) / 2;
    }
}