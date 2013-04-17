using System;

public class Sizes
{
    public static Size GetRotatedSize(Size size, double angleOfTheFigure)
    {
        double sinOfTheFigure = Math.Abs(Math.Sin(angleOfTheFigure));
        double cosOfTheFigure = Math.Abs(Math.Cos(angleOfTheFigure));

        double widthOfTheFigure = (cosOfTheFigure * size.Width) + (sinOfTheFigure * size.Height);
        double heightOfTheFigure = (sinOfTheFigure * size.Width) + (cosOfTheFigure * size.Height);

        Size newSize = new Size(widthOfTheFigure, heightOfTheFigure);
        return newSize;
    }

    public static void Main()
    {
    }

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Width { get; set; }

        public double Height { get; set; }
    }
}