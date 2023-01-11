using System;
using System.Collections.Generic;

namespace E07.HotPotato
{
    internal class HotPotato
    {
        static void Main(string[] args)
        {
            string[] children = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int eleminationTrow = int.Parse(Console.ReadLine());

            Queue<string> childrenPlaying = new Queue<string>();

            foreach (string child in children)
            {
                childrenPlaying.Enqueue(child);
            }

            int NumOfTrows = 1;

            while (childrenPlaying.Count > 1)
            {
                string child = childrenPlaying.Dequeue();

                if (NumOfTrows == eleminationTrow)
                {
                    Console.WriteLine($"Removed {child}");
                    NumOfTrows = 1;
                }
                else
                {
                    childrenPlaying.Enqueue(child);
                    NumOfTrows++;
                }
            }

            Console.WriteLine($"Last is {childrenPlaying.Dequeue()}");
        }
    }
}