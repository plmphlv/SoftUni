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
            bool terminateLoop = false;

            while (!terminateLoop)
            {
                int currentOrder = ordersRN.Dequeue();

                if (totalFood - currentOrder >= 0)
                {
                    totalFood -= currentOrder;
                    if (currentOrder > biggestOrder)
                    {
                        biggestOrder = currentOrder;
                    }
                }


                if (totalFood <= 0 || ordersRN.Count <= 0)
                {
                    terminateLoop = true;
                }
            }

            Console.WriteLine(biggestOrder);

            string finalOutput = (ordersRN.Count == 0) ? "Orders complete" : $"Orders left: {ordersRN.Count}";

            Console.WriteLine(finalOutput);
        }
    }
}