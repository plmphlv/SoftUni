using System;
using System.Linq;

namespace _6.EqualSums
{
    internal class EqualSums
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int magicIndex = 0;

            for (int i = 0; i < elements.Length; i++)
            {
                int leftSum = 0;
                int rightSum = 0;

                for (int j = i + 1; j < elements.Length; j++)
                {
                    rightSum += elements[j];
                }

                for (int k = i - 1; k >= 0; k--)
                {
                    leftSum += elements[k];
                }

                if (leftSum == rightSum)
                {
                    magicIndex = i;
                    break;
                }
                else
                {
                    magicIndex = -1;
                }
            }

            string result = (magicIndex >= 0) ? magicIndex.ToString() : "no";
            Console.WriteLine(result);
        }
    }
}