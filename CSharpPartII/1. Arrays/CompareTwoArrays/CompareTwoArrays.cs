using System;

namespace CompareTwoArrays
{
    class CompareTwoArrays
    {
        static void Main()
        {
            Console.Write("Enter number of elements: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the elements of the first array:");
            int[] firstArray = new int[n];
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Enter the elements of the second array:");
            int[] secondArray = new int[n];
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    Console.WriteLine("{0} = {1}", firstArray[i], secondArray[i]);
                }
                else if (firstArray[i] > secondArray[i])
                {
                    Console.WriteLine("{0} > {1}", firstArray[i], secondArray[i]);
                }
                else
                {
                    Console.WriteLine("{0} < {1}", firstArray[i], secondArray[i]);
                }
            }
        }
    }
}
