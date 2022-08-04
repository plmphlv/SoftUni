using System;

namespace CleverLily
{
    internal class CleverLily
    {
        static void Main(string[] args)
        {
            int ageOfLily = int.Parse(Console.ReadLine());
            double washerCost = double.Parse(Console.ReadLine());
            int pricePerToy = int.Parse(Console.ReadLine());

            int toys = 0;
            double savings = 0;

            for (int currentAge = 1; currentAge <= ageOfLily; currentAge++)
            {
                if (currentAge % 2 == 0)
                {
                    savings += (currentAge * 5) - 1;
                }
                else
                {
                    toys++;
                }
            }

            savings += (pricePerToy * toys);

            if (washerCost <= savings)
            {
                Console.WriteLine($"Yes! {savings - washerCost:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washerCost - savings:f2}");
            }
        }
    }
}
