namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileUtility.GetFileExtension("example"));
            Console.WriteLine(FileUtility.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtility.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtility.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine(
                "Distance in the 2D space = {0:f2}", TwoDUtility.CalculateDistance2D(1, -2, 3, 4));
            Console.WriteLine(
                "Distance in the 3D space = {0:f2}", ThreeDUtility.CalculateDistance3D(5, 2, -1, 3, -6, 4));

            Cuboid cuboid = new Cuboid(3, 4, 5);

            Console.WriteLine(
                "Volume = {0:f2}", ThreeDUtility.CalculateVolume(cuboid.Width, cuboid.Height, cuboid.Depth));
            Console.WriteLine(
                "Diagonal XYZ = {0:f2}", ThreeDUtility.CalculateDiagonalXYZ(cuboid.Width, cuboid.Height, cuboid.Depth));
            Console.WriteLine(
                "Diagonal XY = {0:f2}", TwoDUtility.CalculateDiagonalXY(cuboid.Width, cuboid.Height));
            Console.WriteLine(
                "Diagonal XZ = {0:f2}", TwoDUtility.CalculateDiagonalXZ(cuboid.Width, cuboid.Depth));
            Console.WriteLine(
                "Diagonal YZ = {0:f2}", TwoDUtility.CalculateDiagonalYZ(cuboid.Height, cuboid.Depth));
        }
    }
}
