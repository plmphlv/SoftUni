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

           
            while (deck1.Count > 0 && deck2.Count > 0)
            {

                for (int i = 0; i < Math.Min(deck1.Count,deck2.Count); i++)
                {
                    if (deck1[i] > deck2[i])
                    {
                        deck1.Add(deck1[i]);
                        deck1.RemoveAt(i);
                        deck1.Add(deck2[i]);
                        deck2.RemoveAt(i);
                    }
                    else if (deck1[i] < deck2[i])
                    {
                        deck2.Add(deck2[i]);
                        deck2.RemoveAt(i);
                        deck2.Add(deck1[i]);
                        deck1.RemoveAt(i);
                    }
                    else if ((deck1[i] == deck2[i]))
                    {
                        deck1.RemoveAt(i);
                        deck2.RemoveAt(i);
                    }
                }

            }

            string winner = (deck1.Sum() > deck2.Sum()) ? $"First player wins! Sum: {deck1.Sum()}" : $"Second player wins! Sum: {deck2.Sum()}";
            Console.WriteLine(winner);
        }
    }
}