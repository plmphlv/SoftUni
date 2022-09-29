using System;

namespace _2.PrintNumbersInReverseOrder
{
    internal class PrintNumbersInReverseOrder
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] myNums = new int[n];

            for (int i = 0; i < n; i++)
            {
                myNums[i] = int.Parse(Console.ReadLine());
            }

            for (int i = n - 1; i >= 0; i--)
            {
                Console.Write(myNums[i] + " ");
            }
        }
    }
}