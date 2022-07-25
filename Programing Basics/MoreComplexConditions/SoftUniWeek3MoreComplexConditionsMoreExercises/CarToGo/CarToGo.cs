using System;

namespace CarToGo
{
    internal class CarToGo
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            double rentPrice = 0;

            if (budget <= 100)
            {
                if (season == "Summer")
                {
                    rentPrice = budget * 0.35;
                    Console.WriteLine("Economy class");
                    Console.WriteLine($"Cabrio - {rentPrice:f2}");
                }
                else if (season == "Winter")
                {
                    rentPrice = budget * 0.65;
                    Console.WriteLine("Economy class");
                    Console.WriteLine($"Jeep - {rentPrice:f2}");
                }
            }
            else if (budget <= 500)
            {
                if (season == "Summer")
                {
                    rentPrice = budget * 0.45;
                    Console.WriteLine("Compact class");
                    Console.WriteLine($"Cabrio - {rentPrice:f2}");
                }
                else if (season == "Winter")
                {
                    rentPrice = budget * 0.8;
                    Console.WriteLine("Compact class");
                    Console.WriteLine($"Jeep - {rentPrice:f2}");
                }
            }
            else if (budget > 500)
            {
                rentPrice = budget * 0.9;
                Console.WriteLine("Luxury class");
                Console.WriteLine($"Jeep - {rentPrice:f2}");

            }
        }
    }
}
