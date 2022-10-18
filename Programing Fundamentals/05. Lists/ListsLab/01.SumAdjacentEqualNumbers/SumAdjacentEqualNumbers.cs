using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.SumAdjacentEqualNumbers
{
    internal class SumAdjacentEqualNumbers
    {
        static void Main(string[] args)
        {
            List<double> myNums = Console.ReadLine().Split().Select(double.Parse).ToList();

            for (int i = 0; i < myNums.Count - 1; i++)
            {

                if (myNums[i] == myNums[i + 1])
                {
                    myNums[i] += myNums[i + 1];
                    myNums.RemoveAt(i + 1);
                    i = -1;
                }


            }
            Console.WriteLine(String.Join(" ", myNums));
        }
    }
}