using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.BasicQueueOperations
{
    internal class BasicQueueOperations
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> intStack = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            for (int i = 0; i < tokens[1]; i++)
            {
                intStack.Dequeue();
            }

            if (intStack.Count > 0)
            {
                if (intStack.Contains(tokens[2]))
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine(intStack.Min());
                }
            }
            else
            {
                Console.WriteLine(intStack.Count);
            }
        }
    }
}