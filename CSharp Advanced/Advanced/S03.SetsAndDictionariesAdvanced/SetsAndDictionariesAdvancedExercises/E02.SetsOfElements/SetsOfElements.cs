using System;
using System.Collections.Generic;
using System.Linq;

namespace E02.SetsOfElements
{
    internal class SetsOfElements
    {
        static void Main(string[] args)
        {
            int[] lenghtOfSets = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            HashSet<int> setN = new HashSet<int>();

            for (int i = 0; i < lenghtOfSets[0]; i++)
            {
                setN.Add(int.Parse(Console.ReadLine()));
            }

            HashSet<int> setM = new HashSet<int>();

            for (int i = 0; i < lenghtOfSets[1]; i++)
            {
                setM.Add(int.Parse(Console.ReadLine()));
            }

            

            
            List<int> commons = new List<int>();

            foreach (int num1 in setN)
            {
                foreach (int num2 in setM)
                {
                    if (num1 == num2)
                    {
                        commons.Add(num1);
                        break;
                    }
                }
            }

            Console.WriteLine(String.Join(" ", commons));
        }
    }
}