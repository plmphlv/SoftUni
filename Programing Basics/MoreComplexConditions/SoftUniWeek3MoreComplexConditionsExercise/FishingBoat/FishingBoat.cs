using System;

namespace FishingBoat
{
    internal class FishingBoat
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            int fishermen = int.Parse(Console.ReadLine());
            double cost = 0;

            if (season == "Spring")
            {
                cost = 3000;
            }
            else if (season == "Winter")
            {
                cost = 2600;
            }
            else if (season == "Summer" || season == "Autumn")
            {
                cost = 4200;
            }

            if (fishermen <= 6)
            {
                cost = cost - (cost * 0.1);
            }
            else if (fishermen >= 7 && fishermen <= 11)
            {
                cost = cost - (cost * 0.15);
            }
            else if (fishermen > 12)
            {
                cost = cost - (cost * 0.25);
            }

            if (fishermen % 2 == 0 && season != "Autumn")
            {
                cost = cost - (cost * 0.05);
            }

            if (budget >= cost)
            {
                Console.WriteLine($"Yes! You have {budget - cost:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {cost - budget:f2} leva.");
            }
        }
    }
}
