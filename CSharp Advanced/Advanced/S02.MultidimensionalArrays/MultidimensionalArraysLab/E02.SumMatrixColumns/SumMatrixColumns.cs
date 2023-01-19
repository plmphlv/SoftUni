using System;
using System.Linq;

namespace E02.SumMatrixColumns
{
    internal class SumMatrixColumns
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[sizes[0], sizes[1]];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] matrixNums = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrixNums[j];
                }
            }


            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                int colSum = 0;

                for (int j = 0; j < matrix.GetLength(0); j++)
                {
                    colSum+= matrix[j, i];
                }

                Console.WriteLine(colSum);
            }

        }
    }
}