using System;
using System.Linq;

namespace _5.TopIntegers
{
    internal class TopIntegers
    {
        static void Main(string[] args)
        {
            int[] ints = Console.ReadLine().Split().Select(int.Parse).ToArray();

            for (int i = 0; i < ints.Length; i++)
            {
                int topCandidate = ints[i];

                bool isTop = true;
                for (int j = i + 1; j < ints.Length; j++)
                {
                    if (topCandidate <= ints[j])
                    {
                        isTop = false;
                        break;
                    }
                }

                if (isTop)
                {
                    Console.Write(topCandidate + " ");
                }
            }
        }
    }
}