using System;

namespace StudioBudgetForMovies
{
    internal class Movies
    {
        static void Main(string[] args)
        {
            double movieBudget = double.Parse(Console.ReadLine());
            int stuntmenCount = int.Parse(Console.ReadLine());
            double costumePrice = double.Parse(Console.ReadLine());

            double directorFee = movieBudget * 0.10;
            double totalCostumesPrice = stuntmenCount * costumePrice;

            if (stuntmenCount>150)
            {
                totalCostumesPrice = totalCostumesPrice - (totalCostumesPrice * 0.10);
            }

            double budgetNeeded = (directorFee + totalCostumesPrice);

            if (budgetNeeded>movieBudget)
            {
                budgetNeeded -= movieBudget;
                Console.WriteLine("Not enough money!");
                Console.WriteLine($"Wingard needs {budgetNeeded:f2} leva more.");
            }
            else
            {
                movieBudget -= budgetNeeded;
                Console.WriteLine("Action!");
                Console.WriteLine($"Wingard starts filming with {movieBudget:f2} leva left.");
            }
        }
    }
}
