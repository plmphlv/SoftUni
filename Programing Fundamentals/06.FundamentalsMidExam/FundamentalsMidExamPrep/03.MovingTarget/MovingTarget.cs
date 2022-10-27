using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MovingTarget
{
    internal class MovingTarget
    {
        static void Main(string[] args)
        {
            List<int> targets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

            string command;


            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                int index = int.Parse(cmdArgs[1]);
                int secondArg = int.Parse(cmdArgs[2]);

                switch (cmdArgs[0])
                {
                    case "Add":

                        if (index >= 0 && index < targets.Count)
                        {
                            targets.Insert(index, secondArg);
                        }
                        else
                        {
                            Console.WriteLine("Invalid placement!");
                        }

                        break;
                    case "Shoot":

                        if (index >= 0 && index < targets.Count)
                        {
                            targets[index] -= secondArg;
                            if (targets[index] <= 0)
                            {
                                targets.RemoveAt(index);
                            }
                        }

                        break;
                    case "Strike":

                        if ((index - secondArg >= 0) && (index + secondArg < targets.Count))
                        {
                            targets.RemoveRange(index - secondArg, (secondArg * 2) + 1);
                        }
                        else
                        {
                            Console.WriteLine("Strike missed!");
                        }

                        break;
                        default:
                        break;
                }

            }

            Console.WriteLine(String.Join("|", targets));
        }
    }
}