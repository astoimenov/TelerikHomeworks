using System;

namespace BinSearch
{
    class BinSearch
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n-1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(arr);

            int index = Array.BinarySearch(arr, k);
            while (index < 0)
            {
                if (k < arr[0])
                {
                    break;
                }
                k--;
                index = Array.BinarySearch(arr, k);

            }
            if (index < 0)
            {
                Console.WriteLine("Element not found!");
            }
            else
            {
                Console.WriteLine("Element <= K found at index [{0}] = {1}", index, arr[index]);
            }
        }
    }
}
