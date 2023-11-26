using System;
using System.Collections.Generic;
using System.Linq;

namespace E01.EnergyDrinks
{
    internal class EnergyDrinks
    {
        static void Main(string[] args)
        {
            Stack<int> caffeinе = new Stack<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            Queue<int> redBuls = new Queue<int>(Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray());

            int caffeineInBlood = 0;

            while (caffeinе.Count > 0 && redBuls.Count > 0)
            {
                int curDrink = redBulls.Dequeue();
                int curCaffeinе = caffeinе.Pop();
                int result = curDrink * curCaffeinе;

                if (caffeineInBlood + result <= 300)
                {
                    caffeineInBlood += result;
                }
                else
                {
                    redBulls.Enqueue(curDrink);
                    caffeineInBlood -= 30;

                    if (caffeineInBlood < 0)
                    {
                        caffeineInBlood = 0;
                    }
                }
            }

            if (redBulls.Count > 0)
            {
                Console.WriteLine($"Dinks left: {String.Join(", ", redBulls)}");
            }
            else
            {
                Console.WriteLine("At least Stamat wasn't exceeding the maximum caffeine.");
            }

            Console.WriteLine($"Stamat is going to sleep with {caffeineInBlood} mg caffeine.");
        }
    }
}