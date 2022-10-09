using System;

namespace _7.NxNMatrix
{
    internal class NxNMatrix
    {
        static void Main(string[] args)
        {
            int matrixDimension = int.Parse(Console.ReadLine());
            PrintMatrix(matrixDimension);
        }

        static void PrintMatrix(int dimension)
        {
            for (int i = 1; i <= dimension; i++)
            {
                for (int j = 1; j <= dimension; j++)
                {
                    Console.Write(dimension + " ");
                }
                Console.WriteLine();
            }
        }
    }
}