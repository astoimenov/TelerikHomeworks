using System;
using System.Collections.Generic;

namespace FindSumOfKElements
{
    class FindSumOfKElements
    {
        static void Main()
    {
        Console.Write("Enter number of elements: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter array elements:");
        int[] firstArray = new int[n];
            for (int i = 0; i < n; i++)
                firstArray[i] = int.Parse(Console.ReadLine());
            Console.Write("S = ");
        int s = int.Parse(Console.ReadLine());
        Console.Write("K = ");
        int k = int.Parse(Console.ReadLine());
        bool[] sumArray = new bool[s + 1];
        List<int>[] indexArray = new List<int>[s + 1]; 
 
            for (int i = 0; i < s + 1; i++)
                indexArray[i] = new List<int>();
            int sum = 0;
 
        for (int i = 0; i < firstArray.Length; i++)
        {
            sum = firstArray[i];
            if (sum < sumArray.Length)
            {
                sumArray[sum] = true;
                if (indexArray[sum].Count != 0)
                {
                    indexArray[sum].Clear();
                }
                indexArray[sum].Add(i);
            }            
 
            for (int j = sumArray.Length - 1; j > 0; j--)
            {
                if (sumArray[j] == true && j != firstArray[i])
                {
                    if (sum + j < sumArray.Length)
                    {
                        if (sumArray[sum + j] == false)
                        {
                            foreach (var item in indexArray[j]) 
                            {
                                indexArray[sum + j].Add(item);
 
                            }
                            indexArray[sum + j].Add(i);
                        }
                        sumArray[sum + j] = true;
                       
                    }
                }
            }
 
            if (sumArray[s] == true)
            {
                if (indexArray[s].Count == k)
                {
                    break;
                }
                else
                {
                    indexArray[s].Clear();
                    sumArray[s] = false;
                }
            }
        }
        if (sumArray[s] == true)
        {
            Console.Write("Yes (");
            foreach (var item in indexArray[s])
            {
                Console.Write(firstArray[item]);
                if (item != indexArray[s].Count)
                {
                    Console.Write(";");
                }
 
            }            
            Console.WriteLine(")");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
    }
}
