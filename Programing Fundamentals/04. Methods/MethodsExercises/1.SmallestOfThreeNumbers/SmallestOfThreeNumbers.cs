using System;

namespace _1.SmallestOfThreeNumbers
{
    internal class SmallestOfThreeNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = new int[3];

            for (int i = 0; i < 3; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            GetSmallest(arr);
        }

        static void GetSmallest(int[] parArray)
        {
            int smallestNumber = int.MaxValue;

            foreach (int i in parArray)
            {
                if (i < smallestNumber)
                {
                    smallestNumber = i;
                }
            }
            Console.WriteLine(smallestNumber);
        }
    }
}