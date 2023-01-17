using System;
using System.Linq;

namespace E06.JaggedArrayModification
{
    internal class JaggedArrayModification
    {
        static void Main(string[] args)
        {
            int jaggerDimmension = int.Parse(Console.ReadLine());

            int[][] jagger = new int[jaggerDimmension][];

            for (int row = 0; row < jaggerDimmension; row++)
            {
                jagger[row] = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            }

            string command;
            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int yAxis = int.Parse(cmdArgs[1]);//row
                int xAxis = int.Parse(cmdArgs[2]);//col

                switch (cmdArgs[0])
                {
                    case "add":

                        if (yAxis >= 0 && yAxis < jaggerDimmension && xAxis >= 0 && xAxis < jagger[yAxis].Length)
                        {
                            jagger[yAxis][xAxis] += int.Parse(cmdArgs[3]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }

                        break;

                    case "subtract":

                        if (yAxis >= 0 && yAxis < jaggerDimmension && xAxis >= 0 && xAxis < jagger[yAxis].Length)
                        {
                            jagger[yAxis][xAxis] -= int.Parse(cmdArgs[3]);
                        }
                        else
                        {
                            Console.WriteLine("Invalid coordinates");
                        }

                        break;
                }
            }

            foreach (int[] i in jagger)
            {
                Console.WriteLine(String.Join(" ", i));
            }
        }
    }
}