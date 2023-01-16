using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.StackSum
{
    internal class StackSum
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().ToLower().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> numberStack = new Stack<int>();

            foreach (int num in input)
            {
                numberStack.Push(num);
            }

            string command;

            while ((command = Console.ReadLine().ToLower()) != "end")
            {
                string[] cmdArgs = command.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                switch (cmdArgs[0])
                {
                    case "add":

                        numberStack.Push(int.Parse(cmdArgs[1]));
                        numberStack.Push(int.Parse(cmdArgs[2]));

                        break;
                    case "remove":

                        int numsToRemove = int.Parse(cmdArgs[1]);

                        if (numberStack.Count >= numsToRemove)
                        {

                            for (int i = 0; i < numsToRemove; i++)
                            {
                                numberStack.Pop();
                            }

                        }

                        break;

                }

            }

            Console.WriteLine($"Sum: {numberStack.Sum()}");

        }
    }
}