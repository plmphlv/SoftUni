using System;

namespace ComputerBuildShoping
{
    internal class BuildCostCalculator
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int graphicsCards = int.Parse(Console.ReadLine());
            int intelProcessors = int.Parse(Console.ReadLine());
            int ramSticks = int.Parse(Console.ReadLine());

            double gpuCost = graphicsCards * 250;
            double cpuCost = (gpuCost * 0.35) * intelProcessors;
            double ramCost = (gpuCost * 0.10) * ramSticks;
            double buildCost = gpuCost + cpuCost + ramCost;

            if (graphicsCards>intelProcessors)
            {
                buildCost = buildCost - (buildCost * 0.15);
            }

            if (buildCost<=budget)
            {
                budget = budget - buildCost;
                Console.WriteLine($"You have {budget:f2} leva left!");
            }
            else
            {
                buildCost = buildCost - budget;
                Console.WriteLine($"Not enough money! You need {buildCost:f2} leva more!");
            }
        }
    }
}
