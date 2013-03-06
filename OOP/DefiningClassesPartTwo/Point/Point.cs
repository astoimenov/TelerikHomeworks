using System;
using System.Collections.Generic;

public class Point
{
    static void Main()
    {
        Point3D point = new Point3D(1, 2, 3);
        Point3D pointTwo = new Point3D(3, 4, 5);
        Console.WriteLine(Point3D.startCoord);

        Path firstPath = new Path();
        firstPath.AddPoint(pointTwo);
        firstPath.AddPoint(point);
        firstPath.AddPoint(pointTwo);

        PathStorage.SavePath(firstPath);
        List<Path> pathList = PathStorage.LoadPath();
        foreach (var path in pathList)
        {
            Console.WriteLine("-----Path Start-------");
            foreach (var pointers in path.Paths)
            {
                Console.WriteLine(pointers);
            }
            Console.WriteLine("-----Path End-------");

        }
    }
}