using System;
using System.Linq;

namespace E04.MatrixShuffling
{
    internal class MatrixShuffling
    {
        static void Main(string[] args)
        {
            int[] matrixDimmension = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int[,] matrix = new int[matrixDimmension[0], matrixDimmension[1]];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] newRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = newRow[col];
                }
            }

            string command;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int row1 = int.Parse(cmdArgs[1]);
                int col1 = int.Parse(cmdArgs[2]);
                int row2 = int.Parse(cmdArgs[3]);
                int col2 = int.Parse(cmdArgs[4]);

                if (ValidCommand(matrix, row1, col1, row2, col2, cmdArgs))
                {

                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }

        public static bool ValidCommand(int[,] matrix, int row1, int col1, int row2, int col2, string[] command)
        {
            bool validLenght = false;

            if (matrix.Length == 5)
            {
                validLenght = true;
            }
            else
            {
                return false;
            }

            bool validCoordinates = false;
            if (row1 >= 0 && row1 < matrix.GetLength(0) && col1 >= 0 && col1 < matrix.GetLength(1) &&
                   row2 >= 0 && row2 < matrix.GetLength(0) && col2 >= 0 && col2 < matrix.GetLength(1))
            {
                validCoordinates = true;
            }

            bool validCommand = false;

            if (command[0] == "swap")
            {
                validCommand = true;
            }

            return validLenght && validCoordinates && validCommand;
        }

    }
}