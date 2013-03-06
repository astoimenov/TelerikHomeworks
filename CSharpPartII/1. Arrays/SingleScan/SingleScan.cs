﻿using System;

namespace SingleScan
{
    class SingleScan
    {
        static void Main()
        {
            Console.WriteLine("Enter number of elements:");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            int max = arr[0], maxEnd = arr[0];
            int longSequence = 1, currentSequence = 1;
            int start = 0, startTemp = 0;
            for (int i = 1; i < arr.Length; ++i)
            {
                if (arr[i] + maxEnd > arr[i])
                {
                    maxEnd = arr[i] + maxEnd;
                    currentSequence++;
                }

                else
                {
                    maxEnd = arr[i];
                    startTemp = i;
                    currentSequence = 1;
                }
                if (maxEnd > max)
                {
                    max = maxEnd;
                    longSequence = currentSequence;
                    start = startTemp;
                }
            }
            for (int i = start; i < start + longSequence; ++i)
            {
                Console.WriteLine("{0} ", arr[i]);
            }
        }
    }
}
