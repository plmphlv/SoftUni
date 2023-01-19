using System;
using System.Linq;

namespace E04.SymbolInMatrix
{
    internal class SymbolInMatrix
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            char[,] cube = new char[size, size];

            for (int i = 0; i < cube.GetLength(0); i++)
            {
                string matrixChars = Console.ReadLine();

                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    cube[i, j] = matrixChars[j];
                }
            }

            char searched = char.Parse(Console.ReadLine());
            bool foud = false;
            string location = string.Empty;

            for (int i = 0; i < cube.GetLength(0); i++)
            {

                for (int j = 0; j < cube.GetLength(1); j++)
                {
                    if (cube[i, j] == searched)
                    {
                        location = $"({i}, {j})";
                        foud = true;
                        break;
                    }
                }
            }

            if (foud)
            {
                Console.WriteLine(location);
            }
            else
            {
                Console.WriteLine($"{searched} does not occur in the matrix");
            }
        }
    }
}