using System;
using System.Collections.Generic;

namespace GenerateCombinations
{
    class GenerateCombinations
    {
        static void Main(string[] args)
        {
            Console.Write("K = ");
            int k = int.Parse(Console.ReadLine());
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = i + 1;
            }

            List<string> subsets = new List<string>();
            int maxSubset = (int)Math.Pow(2, n) - 1;
            for (int i = 1; i <= maxSubset; i++)
            {
                string iToBin = Convert.ToString(i, 2);
                int counter = 0;
                for (int index = 0; index < iToBin.Length; index++)
                {
                    if (iToBin[index] == '1')
                    {
                        counter++;
                    }
                }

                if (counter == k)
                {
                    string currentSubset = "";

                    for (int j = 0; j <= n; j++)
                    {
                        int mask = 1 << j;
                        int nAndMask = mask & i;
                        if (nAndMask > 0)
                        {
                            currentSubset += string.Format("{0} ", array[j]);
                        }
                    }
                    subsets.Add(currentSubset);
                }
            }

            subsets.Sort();
            Console.WriteLine(String.Join("\n", subsets));
        }
    }
}