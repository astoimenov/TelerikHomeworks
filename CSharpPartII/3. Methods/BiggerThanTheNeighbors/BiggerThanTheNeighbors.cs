using System;

namespace BiggerThanTheNeighbors
{
    class BiggerThanTheNeighbors
    {
        static bool IsInside(int[] arr, int i)
        {
            return 0 <= i && i < arr.Length;
        }

        static bool Bigger(int[] arr, int i, int j)
        {
            return IsInside(arr, j) ? arr[i] > arr[j] : true;
        }

        static bool BiggerThanNeighbours(int[] arr, int i)
        {
            return Bigger(arr, i, i - 1) && Bigger(arr, i, i + 1);
        }

        static void Main()
        {
            int[] arr = { 1, 5, 2, 3, 3, 3, 4, 3, 4, 4, 5 };

            for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i] + ": " + BiggerThanNeighbours(arr, i));
        }
    }
}
