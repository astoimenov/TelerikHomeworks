namespace Abstraction
{
    using System;

    public class Circle : Figure
    {
        private double radius;

        public double Radius
        {
            get
            {
                return this.radius;
            }

            set
            {
                if (Math.Abs(value - 0) < 0.0001 || value < 0)
                {
                    throw new ArgumentException(
                        "The radius cannot be negative or zero!", "value");
                }

                this.radius = value;
            }
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * Math.PI * this.Radius;
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = Math.PI * this.Radius * this.Radius;
            return surface;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public Circle()
        {
        }
    }
}