using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.PrintEvenNumbers
{
    internal class PrintEvenNumbers
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            Queue<int> queueOfInts = new Queue<int>();

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    queueOfInts.Enqueue(number);
                }
            }

            Console.WriteLine(String.Join(", ", queueOfInts));
        }
    }
}