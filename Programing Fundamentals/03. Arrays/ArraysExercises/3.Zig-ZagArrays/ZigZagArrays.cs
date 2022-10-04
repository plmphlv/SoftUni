using System;
using System.Linq;

namespace _3.Zig_ZagArrays
{
    internal class ZigZagArrays
    {
        static void Main(string[] args)
        {
            int numOfReads = int.Parse(Console.ReadLine());

            int[] arr1 = new int[numOfReads];
            int[] arr2 = new int[numOfReads];

            for (int i = 1; i <= numOfReads; i++)
            {
                int[] reads = Console.ReadLine().Split().Select(int.Parse).ToArray();

                if (i % 2 != 0)
                {
                    arr1[i - 1] = reads[0];
                    arr2[i - 1] = reads[1];
                }
                else
                {
                    arr1[i - 1] = reads[1];
                    arr2[i - 1] = reads[0];
                }
            }
            Console.WriteLine(String.Join(" ", arr1));
            Console.WriteLine(String.Join(" ",arr2));
        }
    }
}