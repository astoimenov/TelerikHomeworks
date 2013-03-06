/*1. Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
 *   Implement the ToString() to enable printing a 3D point.
 *2. Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
 *   Add a static property to return the point O.
 *3. Write a static class with a static method to calculate the distance between two points in the 3D space.
 *4. Create a class Path to hold a sequence of points in the 3D space.
 *   Create a static class PathStorage with static methods to save and load paths from a text file.
 *   Use a file format of your choice.*/

using System;
using System.Text;

public struct Point3D
{
    public int pointX { get; set; }
    public int pointY { get; set; }
    public int pointZ { get; set; }

    public Point3D(int pointX, int pointY, int pointZ) : this()
    {
        this.pointX = pointX;
        this.pointY = pointY;
        this.pointZ = pointZ;
    }

    public static readonly Point3D startCoord = new Point3D(0, 0, 0);

    public override string ToString()
    {
        StringBuilder text = new StringBuilder();
        text.AppendFormat("PointX = {0}", this.pointX.ToString());
        text.AppendLine();
        text.AppendFormat("PointY = {0}", this.pointY.ToString());
        text.AppendLine();
        text.AppendFormat("PointZ = {0}", this.pointZ.ToString());
        text.AppendLine();
        return text.ToString();
    }
}
