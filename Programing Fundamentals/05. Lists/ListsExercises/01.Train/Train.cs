using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Train
{
    internal class Train
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int wagonLimit = int.Parse(Console.ReadLine());
            string command;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] cmdTokens = command.Split().ToArray();

                if (cmdTokens[0] == "Add")
                {
                    wagons.Add(int.Parse(cmdTokens[1]));
                }
                else
                {
                    int passengers = int.Parse(cmdTokens[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if (wagons[i] + passengers <= wagonLimit)
                        {
                            wagons[i] += passengers;
                            break;
                        }
                    }

                }

            }

            Console.WriteLine(String.Join(" ", wagons));
        }
    }
}