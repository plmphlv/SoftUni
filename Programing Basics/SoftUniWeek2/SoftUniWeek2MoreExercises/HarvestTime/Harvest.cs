using System;

namespace HarvestTime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wineYard = int.Parse(Console.ReadLine());
            double grapesPerSqM = double.Parse(Console.ReadLine());
            int wineNorm = int.Parse(Console.ReadLine());
            int workersCount = int.Parse(Console.ReadLine());

            double grapesTotal = (wineYard * grapesPerSqM) * 0.40;
            double wineProduct = grapesTotal / 2.5;

            if (wineProduct >= wineNorm)
            {
                double wineLeft = Math.Ceiling(wineProduct - wineNorm);
                double wineSplit = Math.Ceiling(wineLeft / workersCount);
                Console.WriteLine($"Good harvest this year! Total wine: {wineProduct} liters.");
                Console.WriteLine($"{wineLeft} liters left -> {wineSplit} liters per person.");
            }
            else
            {
                double wineNeeded = Math.Floor(wineNorm - wineProduct);
                Console.WriteLine($"It will be a tough winter! More {wineNeeded} liters wine needed.");
            }
        }
    }
}
