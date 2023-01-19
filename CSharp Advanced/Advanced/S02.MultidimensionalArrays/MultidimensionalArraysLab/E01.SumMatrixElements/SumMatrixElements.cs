using System;
using System.Linq;

namespace E01.SumMatrixElements
{
    internal class SumMatrixElements
    {
        static void Main(string[] args)
        {
            int[] matrixSpecs = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixSpecs[0], matrixSpecs[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
               int[] matrixNums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrixNums[j];
                }
            }

            int matrixSum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrixSum += matrix[row, col];
                }
            }

            Console.WriteLine(matrix.GetLength(0));
            Console.WriteLine(matrix.GetLength(1));
            Console.WriteLine(matrixSum);
        }
    }
}