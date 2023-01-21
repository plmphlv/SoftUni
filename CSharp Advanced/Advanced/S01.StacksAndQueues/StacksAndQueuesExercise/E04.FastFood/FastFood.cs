using System;
using System.Collections.Generic;
using System.Linq;

namespace E04.FastFood
{
    internal class FastFood
    {
        static void Main(string[] args)
        {
            int totalFood = int.Parse(Console.ReadLine());

            Queue<int> ordersRN = new(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int biggestOrder = int.MinValue;

            Console.WriteLine(ordersRN.Max());

            while (ordersRN.Any())
            {
                totalFood -= ordersRN.Peek();

                if (totalFood < 0)
                {
                    break;
                }

                ordersRN.Dequeue();
            }

            string finalOutput = (ordersRN.Count == 0) ? "Orders complete" : $"Orders left: {string.Join(" ", ordersRN)}";

            Console.WriteLine(finalOutput);
        }
    }
}