using System;
using System.Collections.Generic;

namespace LongestSequenceOfEqualStrings
{
    class LongestSequenceOfEqualStrings
    {
        static void Main()
        {
            Console.Write("N =  ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M =  ");
            int m = int.Parse(Console.ReadLine());
            string[,] matrix = new string[n, m];
            List<string> listMaxSeq = new List<string>();
            int curSum = 1, maxSum = 0, tempRow = 1, tempCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int coll = 0; coll < m; coll++)
                {
                    matrix[row, coll] = Console.ReadLine();
                }
            }

            Console.WriteLine("Main marix:");
            for (int row = 0; row < n; row++)
            {
                for (int coll = 0; coll < m; coll++)
                {
                    Console.Write("{0,5}", matrix[row, coll]);
                }
                Console.WriteLine();
            }

            for (int row = 0; row < n; row++)
            {
                for (int coll = 0; coll < m - 1; coll++)
                {
                    curSum = ((matrix[row, coll] == matrix[row, coll + 1]) ? ++curSum : 1);
                    if (curSum == maxSum)
                    {
                        listMaxSeq.Add(matrix[row, coll]);
                    }
                    else if (curSum > maxSum)
                    {
                        maxSum = curSum;
                        listMaxSeq.Clear();
                        listMaxSeq.Add(matrix[row, coll]);
                    }
                }
                curSum = 1;
            }

            for (int coll = 0; coll < m; coll++)
            {
                for (int row = 0; row < n - 1; row++)
                {
                    curSum = ((matrix[row, coll] == matrix[row + 1, coll]) ? ++curSum : 1);
                    if (curSum == maxSum)
                    {
                        listMaxSeq.Add(matrix[row, coll]);
                    }
                    else if (curSum > maxSum)
                    {
                        maxSum = curSum;
                        listMaxSeq.Clear();
                        listMaxSeq.Add(matrix[row, coll]);
                    }
                }
                curSum = 1;
            }

            for (int i = 0; i < m - 1; i++)
            {
                for (int row = 0, coll = tempCol; row < n - 1 && coll < m - 1; row++, coll++)
                {
                    curSum = ((matrix[row, coll] == matrix[row + 1, coll + 1]) ? ++curSum : 1);
                    if (curSum == maxSum)
                    {
                        listMaxSeq.Add(matrix[row, coll]);
                    }
                    else if (curSum > maxSum)
                    {
                        maxSum = curSum;
                        listMaxSeq.Clear();
                        listMaxSeq.Add(matrix[row, coll]);
                    }
                }
                tempCol++;
                curSum = 1;
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int row = tempRow, coll = 0; row < n - 1 && coll < m - 1; row++, coll++)
                {
                    curSum = ((matrix[row, coll] == matrix[row + 1, coll + 1]) ? ++curSum : 1);
                    if (curSum == maxSum)
                    {
                        listMaxSeq.Add(matrix[row, coll]);
                    }
                    else if (curSum > maxSum)
                    {
                        maxSum = curSum;
                        listMaxSeq.Clear();
                        listMaxSeq.Add(matrix[row, coll]);
                    }
                }
                tempRow++;
                curSum = 1;
            }


            Console.WriteLine("Max sequence is of {0} elemets", maxSum);
            for (int i = 0; i < listMaxSeq.Count; i++)
            {
                Console.Write(listMaxSeq[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
