using System;
using System.Collections.Generic;
using System.Linq;

namespace _04.ListOperations
{
    internal class ListOperations
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] cmdTokens = command.Split().ToArray();

                switch (cmdTokens[0])
                {
                    case "Add":
                        list.Add(int.Parse(cmdTokens[1]));
                        break;
                    case "Insert":

                        if (int.Parse(cmdTokens[2]) >= 0 && int.Parse(cmdTokens[2]) < list.Count)
                        {
                            list.Insert(int.Parse(cmdTokens[2]), int.Parse(cmdTokens[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;
                    case "Remove":

                        if (int.Parse(cmdTokens[1]) >= 0 && int.Parse(cmdTokens[1]) < list.Count)
                        {
                            list.RemoveAt(int.Parse(cmdTokens[1]));
                        }
                        else
                        {
                            Console.WriteLine("Invalid index");
                        }

                        break;
                    case "Shift":

                        if (cmdTokens[1] == "left")
                        {
                            int numOfLoops = int.Parse(cmdTokens[2]);
                            for (int i = 0; i < numOfLoops; i++)
                            {
                                list.Add(list[0]);
                                list.Remove(list[0]);
                            }
                        }
                        else if (cmdTokens[1] == "right")
                        {
                            int numOfLoops = int.Parse(cmdTokens[2]);
                            for (int i = 0; i < numOfLoops; i++)
                            {
                                list.Insert(0, list[list.Count - 1]);
                                list.RemoveAt(list.Count - 1);
                            }
                        }

                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}