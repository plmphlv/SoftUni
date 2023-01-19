using System;
using System.Linq;

namespace E05.SquareWithMaximumSum
{
    internal class SquareWithMaximumSum
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

            int[,] maxCube = new int[2, 2];
            int maxCubeTotalSum = int.MinValue;

            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    int sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > maxCubeTotalSum)
                    {
                        maxCubeTotalSum = sum;
                        maxCube[0, 0] = matrix[i, j];
                        maxCube[0, 1] = matrix[i, j + 1];
                        maxCube[1, 0] = matrix[i + 1, j];
                        maxCube[1, 1] = matrix[i + 1, j + 1];
                    }
                }
            }

            for (int i = 0; i < maxCube.GetLength(0); i++)
            {
                for (int j = 0; j < maxCube.GetLength(1); j++)
                {
                    Console.Write($"{maxCube[i, j]} ");
                }

                Console.WriteLine();
            }

            Console.WriteLine(maxCubeTotalSum);
        }
    }
}