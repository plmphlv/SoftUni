using System;
using System.Collections.Generic;
using System.Linq;

namespace E05.FashionBoutique
{
    internal class FashionBoutique
    {
        static void Main(string[] args)
        {
            Stack<int> boxes = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int rackCapacity = int.Parse(Console.ReadLine());

            int racks = 1;
            int currRack = rackCapacity;

            while (boxes.Any())
            {
                currRack -= boxes.Peek();

                if (currRack < 0)
                {
                    racks++;
                    currRack = rackCapacity;
                    continue;
                }

                boxes.Pop();
            }

            Console.WriteLine(racks);
        }
    }
}