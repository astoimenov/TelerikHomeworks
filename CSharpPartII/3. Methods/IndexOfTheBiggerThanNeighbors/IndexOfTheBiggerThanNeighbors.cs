using System;

namespace IndexOfTheBiggerThanNeighbors
{
    class IndexOfTheBiggerThanNeighbors
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

        static int GetIndex(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                if (BiggerThanNeighbours(arr, i)) return i;

            return -1;
        }

        static void Main()
        {
            int[] arr = { 1, 2, 2, 3, 2 };

            Console.WriteLine(GetIndex(arr));
        }
    }
}
