using System;
using System.Collections.Generic;
using System.Linq;

namespace _05.BombNumbers
{
    internal class BombNumbers
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            int[] bombAndPower = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (list.Contains(bombAndPower[0]))
            {
                for (int i = 0; i < bombAndPower[1]; i++)
                {

                    if ((list.IndexOf(bombAndPower[0])) - 1 - 1 >= 0 && (list.IndexOf(bombAndPower[0])) + 1 < list.Count)
                    {
                        list.RemoveAt(list.IndexOf(bombAndPower[0]) - 1);
                    }
                    
                    if ((list.IndexOf(bombAndPower[0])) - 1 >= 0 && (list.IndexOf(bombAndPower[0])) + 1 < list.Count)
                    {
                        list.RemoveAt(list.IndexOf(bombAndPower[0]) + 1);
                    }
                }
                list.RemoveAt(list.IndexOf(bombAndPower[0]));

            }

            Console.WriteLine(list.Sum());
        }
    }
}