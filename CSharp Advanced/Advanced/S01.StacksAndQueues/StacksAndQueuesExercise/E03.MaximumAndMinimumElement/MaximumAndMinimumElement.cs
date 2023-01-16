using System;
using System.Collections.Generic;
using System.Linq;

namespace E03.MaximumAndMinimumElement
{
    internal class MaximumAndMinimumElement
    {
        static void Main(string[] args)
        {
            int queries = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < queries; i++)
            {
                string[] cmdTokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int command = int.Parse(cmdTokens[0]);
                switch (command)
                {
                    case 1:

                        stack.Push(int.Parse(cmdTokens[1]));

                        break;

                    case 2:

                        stack.Pop();

                        break;

                    case 3:

                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Max());
                        }

                        break;

                    case 4:

                        if (stack.Count > 0)
                        {
                            Console.WriteLine(stack.Min());
                        }

                        break;
                }

                Console.WriteLine(string.Join(" ", stack));
            }
        }
    }
}