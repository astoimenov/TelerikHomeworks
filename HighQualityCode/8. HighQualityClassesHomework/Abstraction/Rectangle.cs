namespace Abstraction
{
    using System;

    public class Rectangle : Figure
    {
        private double width;
        private double height;

        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (Math.Abs(value - 0) < 0.0001 || value < 0)
                {
                    throw new ArgumentException("The width cannot be negative or zero!", "value");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (Math.Abs(value - 0) < 0.0001 || value < 0)
                {
                    throw new ArgumentException("The height cannot be negative or zero!", "value");
                }

                this.height = value;
            }
        }

        public Rectangle()
        {
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        public override double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public override double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}