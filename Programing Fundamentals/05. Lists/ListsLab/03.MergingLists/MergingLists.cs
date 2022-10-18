using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.MergingLists
{
    internal class MergingLists
    {
        static void Main(string[] args)
        {
            List<int> myList = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> myList2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            List<int> finalList = new List<int>();

            int smallestCount = Math.Min(myList.Count, myList2.Count);

            for (int i = 0; i < smallestCount; i++)
            {
                finalList.Add(myList[i]);
                finalList.Add(myList2[i]);
            }

            if (myList.Count > myList2.Count)
            {
                for (int i = smallestCount; i < myList.Count; i++)
                {
                    finalList.Add(myList[i]);
                }
            }
            else if (myList.Count < myList2.Count)
            {
                for (int i = smallestCount; i < myList2.Count; i++)
                {
                    finalList.Add(myList2[i]);
                }
            }

            Console.WriteLine(String.Join(" ", finalList));
        }
    }
}