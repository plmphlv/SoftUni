using System;

namespace ShishoBakshisho
{
    internal class SasipahaYaTayadurjava
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            string timeOfDay = Console.ReadLine();
            double price = 0;

            if (distance >= 100)
            {
                price = 0.06 * distance;
                Console.WriteLine($"{price:f2}");
            }
            else if (distance >= 20)
            {
                price = 0.09 * distance;
                Console.WriteLine($"{price:f2}");
            }
            else
            {
                if (timeOfDay == "day")
                {
                    price = 0.70 + 0.79 * distance;
                    Console.WriteLine($"{price:f2}");
                }
                else if (timeOfDay == "night")
                {
                    price = 0.70 + 0.90 * distance;
                    Console.WriteLine($"{price:f2}");
                }
            }
        }
    }
}
