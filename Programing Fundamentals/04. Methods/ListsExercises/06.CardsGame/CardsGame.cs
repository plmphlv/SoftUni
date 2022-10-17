using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace _06.CardsGame
{
    internal class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> deck1 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> deck2 = Console.ReadLine().Split().Select(int.Parse).ToList();

            int index = 0;
            bool reset = index >= deck1.Count;
            while (deck1.Count > 0 || deck2.Count > 0)
            {
                if (reset)
                {
                    index = 0;
                }

                if (deck1[index] > deck2[index])
                {
                    deck1.Add(deck2[index]);
                    deck2.RemoveAt(index);
                }
                else
                {
                    deck2.Add(deck1[index]);
                    deck1.RemoveAt(index);
                }

                
                index++;
            }

            string winner = (deck1.Sum() > deck2.Sum()) ? $"First player wins! Sum: {deck1.Sum()}" : $"Second player wins! Sum: {deck2.Sum()}";
            Console.WriteLine(winner);
        }
    }
}