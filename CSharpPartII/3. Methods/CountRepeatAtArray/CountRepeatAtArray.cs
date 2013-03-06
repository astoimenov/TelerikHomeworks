using System;

namespace CountRepeatAtArray
{
    class CountRepeatAtArray
    {
        static int Count(int[] arr, int arrLength, int num)
        {
            int counter = 0;
            for (int i = 0; i < arrLength; i++)
            {
                if (arr[i] == num)
                {
                    counter++;
                }
            }
            return counter;
        }
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int [n];
            for (int i = 0; i < arr.Length-1; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Search for the number: ");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(Count(arr, arr.Length, m));
        }
    }
}
