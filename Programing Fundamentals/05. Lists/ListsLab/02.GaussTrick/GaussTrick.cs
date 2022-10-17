using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.GaussTrick
{
    internal class GaussTrick
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int originalLengh = list.Count / 2;

            for (int i = 0; i < originalLengh; i++)
            {
                list[i] += list[list.Count - 1];
                list.RemoveAt(list.Count - 1);
            }

            Console.WriteLine(String.Join(" ", list));
        }
    }
}