using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.BasicStackOperations
{
    internal class BasicStackOperations
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Stack<int> intStack = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            for (int i = 0; i < tokens[1]; i++)
            {
                intStack.Pop();
            }

            if(intStack.Count > 0)
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