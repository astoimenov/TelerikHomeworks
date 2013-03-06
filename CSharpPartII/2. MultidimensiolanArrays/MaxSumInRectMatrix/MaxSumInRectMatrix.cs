using System;

namespace MaxSumInRectMatrix
{
    class MaxSumInRectMatrix
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("M = ");
            int m = int.Parse(Console.ReadLine());
            int[,] matrix;
            matrix = new int[n, m];

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {

                for (int j = 0; j < m; j++)
                {

                    matrix[i, j] = rand.Next(-5,90);

                }
            }

            int area = 3;
            int sum = int.MinValue;
            int maxSum = int.MinValue;
            int startRow = 0;
            int startCol = 0;

            for (int row = 0; row < matrix.GetLength(0) - area - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - area - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col]
                        + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                        startCol = col;
                        startRow = row;
                    }
                }
            }
            Console.WriteLine(maxSum);

            for (int row = startRow; row < startRow + area; row++)
            {
                for (int col = startCol; col < startCol + area; col++)
                {
                    Console.Write("{0,3}", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
