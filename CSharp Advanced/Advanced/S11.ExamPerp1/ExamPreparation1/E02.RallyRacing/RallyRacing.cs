using System;

namespace E02.RallyRacing
{
    internal class RallyRacing
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            string carNum = Console.ReadLine();

            string[,] track = new string[size, size];

            int firstTunnelRow = 0;
            int firstTunnelCol = 0;

            int secondTunnelRow = 0;
            int secondTunnelCol = 0;

            bool foundFirstTunnel = false;


            for (int row = 0; row < size; row++)
            {
                string[] rowData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int col = 0; col < size; col++)
                {
                    if (rowData[col] == "T" && !foundFirstTunnel)
                    {
                        foundFirstTunnel = true;
                        firstTunnelCol = col;
                        firstTunnelRow = row;
                    }
                    else if (rowData[col] == "T")
                    {
                        secondTunnelCol = col;
                        secondTunnelRow = row;
                    }

                    track[row, col] = rowData[col];
                }
            }

            int carRow = 0;
            int carCol = 0;
            int km = 0;

            bool finish = false;

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                switch (command)
                {
                    case "down":
                        carRow++;
                        break;
                    case "up":
                        carRow--;
                        break;
                    case "left":
                        carCol--;
                        break;
                    case "right":
                        carCol++;
                        break;
                }

                if (track[carRow, carCol] == ".")
                {
                    km += 10;
                }
                if (track[carRow, carCol] == "T")
                {
                    track[carRow, carCol] = ".";

                    if (carRow == firstTunnelRow && carCol == firstTunnelCol)
                    {
                        carRow = secondTunnelRow;
                        carCol = secondTunnelCol;
                    }
                    else
                    {
                        carRow = firstTunnelRow;
                        carCol = firstTunnelCol;
                    }
                    track[carRow, carCol] = ".";
                    km += 30;
                }
                if (track[carRow, carCol] == "F")
                {
                    km += 10;
                    track[carRow, carCol] = "C";
                    finish = true;
                    break;
                }

            }

            if (finish)
            {
                Console.WriteLine($"Racing car {carNum} finished the stage!");
            }
            else
            {
                Console.WriteLine($"Racing car {carNum} DNF.");
            }

            Console.WriteLine($"Distance covered {km} km.");

            PrintMatrix(track);
        }

        public static void PrintMatrix<T>(T[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }
    }
}