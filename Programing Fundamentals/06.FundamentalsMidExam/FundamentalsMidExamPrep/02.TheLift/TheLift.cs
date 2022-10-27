using System;
using System.Linq;

namespace _02.TheLift
{
    internal class TheLift
    {
        static void Main(string[] args)
        {
            int passengers = int.Parse(Console.ReadLine());
            int[] wagons = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            for (int i = 0; i < wagons.Length; i++)
            {
                if (wagons[i] < 4 && passengers > 0)
                {
                    int diff = 4 - wagons[i];
                    wagons[i] += diff;
                    passengers -= diff;

                    if (passengers < 0)
                    {
                        wagons[i] += passengers;
                    }
                }

            }

            if (passengers > 0)
            {
                Console.WriteLine($"There isn't enough space! {passengers} people in a queue!");
                Console.WriteLine(String.Join(" ", wagons));
            }
            else if (passengers <= 0 && wagons.Any(x => x < 4))
            {
                Console.WriteLine("The lift has empty spots!");
                Console.WriteLine(String.Join(" ", wagons));
            }
            else
            {
                Console.WriteLine(String.Join(" ", wagons));
            }
        }
    }
}