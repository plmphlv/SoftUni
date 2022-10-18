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
                    int bombIndexOfDesctructionLeft = list.IndexOf(bombAndPower[0]) - 1;

                    if (bombIndexOfDesctructionLeft >= 0 && bombIndexOfDesctructionLeft < list.Count)
                    {
                        list.RemoveAt(bombIndexOfDesctructionLeft);
                    }

                    int bombIndexOfDesctructionRight = list.IndexOf(bombAndPower[0]) + 1;

                    if (bombIndexOfDesctructionRight >= 0 && bombIndexOfDesctructionRight < list.Count)
                    {
                        list.RemoveAt(bombIndexOfDesctructionRight);
                    }
                }
                list.RemoveAt(list.IndexOf(bombAndPower[0]));

            }

            Console.WriteLine(list.Sum());
        }
    }
}