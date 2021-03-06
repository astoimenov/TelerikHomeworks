﻿using System;

namespace MaxSequenceofEqualEls
{
    class MaxSequenceofEqualEls
    {
        static void Main()
        {
            int count = 0, max = 0, index = 0, i;
            Console.Write("Enter number of elements:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            Console.WriteLine("Enter {0} elements", n);
            for (i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            for (i = 0; i < n - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                    if (max < count)
                    {
                        max = count; index = i + 1;
                    }
                }
                else
                {
                    count = 0;
                }
            }
            if (max != 0)
            {
                for (i = index; i > index - max; i--)
                {
                    Console.Write(array[i] + ", ");
                }
                if (i == index - max)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
