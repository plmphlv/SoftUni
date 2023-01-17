using System;
using System.Linq;

namespace E03.PrimaryDiagonal
{
    internal class PrimaryDiagonal
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[,] cube = new int[size, size];

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                int[] matrixNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    cube[i, j] = matrixNums[j];
                }
            }

            int diagonalSum = 0;

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                diagonalSum += cube[i, i];
            }

            Console.WriteLine(diagonalSum);
        }
    }
}