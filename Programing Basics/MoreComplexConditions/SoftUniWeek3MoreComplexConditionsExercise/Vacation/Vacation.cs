using System;

namespace Vacation
{
    internal class Vacation
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();
            string destination = string.Empty;
            string resortType = string.Empty;

            if (budget <= 1000)
            {
                resortType = "Camp";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    budget = budget * 0.65;
                    Console.WriteLine($"{destination} - {resortType} - {budget:f2}");
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    budget = budget * 0.45;
                    Console.WriteLine($"{destination} - {resortType} - {budget:f2}");
                }
            }
            else if (budget <= 3000)
            {
                resortType = "Hut";
                if (season == "Summer")
                {
                    destination = "Alaska";
                    budget = budget * 0.8;
                    Console.WriteLine($"{destination} - {resortType} - {budget:f2}");
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                    budget = budget * 0.6;
                    Console.WriteLine($"{destination} - {resortType} - {budget:f2}");
                }
            }
            else if (budget > 3000)
            {
                resortType = "Hotel";
                budget = budget * 0.9;

                if (season == "Summer")
                {
                    destination = "Alaska";
                }
                else if (season == "Winter")
                {
                    destination = "Morocco";
                }

                Console.WriteLine($"{destination} - {resortType} - {budget:f2}");
            }
        }
    }
}
