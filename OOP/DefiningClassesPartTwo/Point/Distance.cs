using System;

public static class Distance
{
    public static double CalcDistance (Point3D firstPoint, Point3D secondPoint)
    {
        double distance = 0;
        distance = Math.Sqrt(Math.Pow(firstPoint.pointX - secondPoint.pointX, 2) + Math.Pow(firstPoint.pointY - secondPoint.pointY, 2) + Math.Pow(firstPoint.pointZ - secondPoint.pointZ, 2));
        return distance;
    }
}
