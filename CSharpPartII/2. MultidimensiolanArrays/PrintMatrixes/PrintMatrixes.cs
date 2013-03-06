using System;

namespace PrintMatrixes
{
    class PrintMatrixes
    {
        static void Main()
        {
            Console.Write("N = ");
            int n = int.Parse(Console.ReadLine());
            int filler = 1;
            int[,] matrix;
            matrix = new int[n, n];
            Console.WriteLine();

            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    matrix[row, col] = filler;
                    filler++;
                }
            }
            Console.WriteLine("a)");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            filler = 1;
            Array.Clear(matrix, 0, matrix.Length);

            for (int col = 0; col < n; col++)
            {
                if ((col % 2) == 0)
                {
                    for (int row = 0; row < n; row++)
                    {
                        matrix[row, col] = filler;
                        filler++;
                    }
                }
                else
                {
                    for (int row = n - 1; row >= 0; row--)
                    {
                        matrix[row, col] = filler;
                        filler++;
                    }
                }
            }
            Console.WriteLine("b)");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            filler = 1;
            Array.Clear(matrix, 0, matrix.Length);

            for (int diag = 0; diag < (n * 2) - 1; diag++)
            {
                int row = n - 1 - diag;
                if (row < 0)
                {
                    row = 0;
                }
                int col = 0;
                if (diag >= n)
                {
                    col = diag - n + 1;
                }
                while ((row < n) && (col < n))
                {
                    matrix[row, col] = filler;
                    filler++;
                    row++;
                    col++;
                }
            }
            Console.WriteLine("c)");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            filler = 1;
            Array.Clear(matrix, 0, matrix.Length);

            for (int rotation = 0; filler <= n * n; )
            {
                for (int down = n - (rotation * 2), row = 0 + rotation, col = 0 + rotation; down > 0; down--)
                {
                    matrix[row, col] = filler;
                    filler++;
                    row++;
                }
                for (int right = n - (1 + (rotation * 2)), row = n - (1 + rotation), col = 1 + rotation; right > 0; right--)
                {
                    matrix[row, col] = filler;
                    filler++;
                    col++;
                }
                for (int up = n - (1 + (rotation * 2)), row = n - (2 + rotation), col = n - (1 + rotation); up > 0; up--)
                {
                    matrix[row, col] = filler;
                    filler++;
                    row--;
                }
                for (int left = n - (2 + (rotation * 2)), row = 0 + rotation, col = n - (2 + rotation); left > 0; left--)
                {
                    matrix[row, col] = filler;
                    filler++;
                    col--;
                }
                rotation++;
            }
            Console.WriteLine("d)");
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write("{0} ", matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}
