using System;

namespace TruckDriver
{
    internal class TruckDriver
    {
        static void Main(string[] args)
        {
            string season = Console.ReadLine();
            double distance = double.Parse(Console.ReadLine());

            double pricePerKm = 0;
            double earnins = 0;
            double proffit = 0;

            if (distance <= 5000)
            {
                if (season == "Spring" || season == "Autumn")
                    pricePerKm = 0.75;
                else if (season == "Summer")
                    pricePerKm = 0.9;
                else if (season == "Winter")
                    pricePerKm = 1.05;
            }
            else if (distance > 5000 && distance <= 10000)
            {
                if (season == "Spring" || season == "Autumn")
                    pricePerKm = 0.95;
                else if (season == "Summer")
                    pricePerKm = 1.1;
                else if (season == "Winter")
                    pricePerKm = 1.25;
            }
            else if (distance > 10000 && distance <= 20000)
            {
                pricePerKm = 1.45;
            }

            earnins = (pricePerKm * distance)*4;
            proffit = earnins - (earnins * 0.1);

            Console.WriteLine($"{proffit:f2}");

        }
    }
}
