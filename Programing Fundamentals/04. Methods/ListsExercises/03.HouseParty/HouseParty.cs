using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.HouseParty
{
    internal class HouseParty
    {
        static void Main(string[] args)
        {
            int numOfCmds = int.Parse(Console.ReadLine());
            List<string> guestList = new List<string>();

            for (int i = 0; i < numOfCmds; i++)
            {
                string[] commands = Console.ReadLine().Split().ToArray();

                if (commands.Length == 3)
                {
                    if (!guestList.Contains(commands[0]))
                    {
                        guestList.Add(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is already in the list!");
                    }
                }
                else if (commands.Length == 4)
                {
                    if (guestList.Contains(commands[0]))
                    {
                        guestList.Remove(commands[0]);
                    }
                    else
                    {
                        Console.WriteLine($"{commands[0]} is not in the list!");
                    }
                }
            }

            Console.WriteLine(string.Join(Environment.NewLine, guestList));
        }
    }
}