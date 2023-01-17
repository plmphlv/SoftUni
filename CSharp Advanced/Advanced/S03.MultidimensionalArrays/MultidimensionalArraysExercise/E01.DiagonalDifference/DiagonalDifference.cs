using System;
using System.Drawing;
using System.Linq;

namespace E01.DiagonalDifference
{
    internal class DiagonalDifference
    {
        static void Main(string[] args)
        {
            int matrixDimmension = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixDimmension, matrixDimmension];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] newRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = newRow[col];
                }
            }

            int leftDiagonal = 0;
            int rightDiagonal = 0;

            for (int i = 0; i < matrixDimmension; i++)
            {
                leftDiagonal += matrix[i, i];
                rightDiagonal += matrix[matrixDimmension - i - 1, i];
            }

            Console.WriteLine(Math.Abs(leftDiagonal - rightDiagonal));
        }
    }
}