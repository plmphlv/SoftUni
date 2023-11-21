using System;
using System.Linq;

namespace E02.BlindManSBuff
{
    internal class BlindManSBuff
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            char[][] field = new char[size[0]][];

            int playerRow = 0;
            int playerCol = 0;

            for (int row = 0; row < size[0]; row++)
            {
                field[row] = new char[size[1]];

                char[] fieldRowElements = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();

                for (int col = 0; col < size[1]; col++)
                {
                    if (fieldRowElements[col] == 'B')
                    {
                        playerRow = row;
                        playerCol = col;
                    }

                    field[row][col] = fieldRowElements[col];
                }
            }


            int touched = 0;
            int moves = 0;

            string command;
            while ((command = Console.ReadLine()) != "Finish" && touched < 3)
            {
                int newPositionRow = playerRow;
                int newPositionCol = playerCol;

                switch (command)
                {
                    case "up": newPositionRow--; break;
                    case "down": newPositionRow++; break;
                    case "left": newPositionCol--; break;
                    case "right": newPositionCol++; break;
                }

                if (newPositionRow >= 0 && newPositionRow < size[0] && newPositionCol >= 0 && newPositionCol < size[1])
                {
                    if (field[newPositionRow][newPositionCol] == 'O')
                    {
                        continue;
                    }
                    else if (field[newPositionRow][newPositionCol] == 'P')
                    {
                        touched++;
                        field[playerRow][playerCol] = '-';
                    }

                    moves++;
                    playerRow = newPositionRow;
                    playerCol = newPositionCol;
                }
            }

            Console.WriteLine("Game over!");
            Console.WriteLine($"Touched opponents: {touched} Moves made: {moves}");
        }
    }
}