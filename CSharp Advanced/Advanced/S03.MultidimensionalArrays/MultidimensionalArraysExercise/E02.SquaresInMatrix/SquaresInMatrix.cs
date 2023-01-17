using System;
using System.Linq;

namespace E02.SquaresInMatrix
{
    internal class SquaresInMatrix
    {
        static void Main(string[] args)
        {
            int[] matrixDimmension = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[,] matrix = new char[matrixDimmension[0], matrixDimmension[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] newRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = newRow[col];
                }
            }

            int cubes = 0;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        cubes++;
                    }
                }
            }

            Console.WriteLine(cubes);
        }
    }
}