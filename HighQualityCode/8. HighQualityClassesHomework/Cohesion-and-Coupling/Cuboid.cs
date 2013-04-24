namespace CohesionAndCoupling
{
    using System;

    public class Cuboid
    {
        private double width;
        private double height;
        private double depth;

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

        public double Depth
        {
            get
            {
                return this.depth;
            }

            set
            {
                if (Math.Abs(value - 0) < 0.0001 || value < 0)
                {
                    throw new ArgumentException("The depth cannot be negative or zero!", "value");
                }

                this.depth = value;
            }
        }

        public Cuboid(double width, double height, double depth)
        {
            this.Width = width;
            this.Height = height;
            this.Depth = depth;
        }
    }
}