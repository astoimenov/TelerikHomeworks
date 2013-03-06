using System;
using System.Collections.Generic;

public class Path
{
    public readonly List<Point3D> points = new List<Point3D>();
    public List<Point3D> Paths
    {
        get { return this.points; }
    }

    public void AddPoint(Point3D point)
    {
        points.Add(point);
    }

    public void ClearPaths()
    {
        points.Clear();
    }
}
