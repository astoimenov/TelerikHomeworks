namespace CohesionAndCoupling
{
    using System;

    public class TwoDUtility
    {
        public static double CalculateDistance2D(double x1, double y1, double x2, double y2)
        {
            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        public static double CalculateDiagonalXY(double width, double height)
        {
            double distance = CalculateDistance2D(0, 0, width, height);
            return distance;
        }

        public static double CalculateDiagonalXZ(double width, double depth)
        {
            double distance = CalculateDistance2D(0, 0, width, depth);
            return distance;
        }

        public static double CalculateDiagonalYZ(double height, double depth)
        {
            double distance = CalculateDistance2D(0, 0, height, depth);
            return distance;
        }
    }
}