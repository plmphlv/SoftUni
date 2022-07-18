using System;

namespace NewHouse
{
    internal class NewHouse
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();
            int flowerQty = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());
            double finalTotal = 0;

            switch (flowers)
            {
                case "Roses":
                    finalTotal = flowerQty * 5;
                    if (flowerQty > 80)
                    {
                        finalTotal = finalTotal - (finalTotal * 0.1);
                    }
                    break;
                case "Dahlias":
                    finalTotal = flowerQty * 3.8;
                    if (flowerQty > 90)
                    {
                        finalTotal = finalTotal - (finalTotal * 0.15);
                    }
                    break;
                case "Tulips":
                    finalTotal = flowerQty * 2.8;
                    if (flowerQty > 80)
                    {
                        finalTotal = finalTotal - (finalTotal * 0.15);
                    }
                    break;
                case "Narcissus":
                    finalTotal = flowerQty * 3;
                    if (flowerQty < 120)
                    {
                        finalTotal = finalTotal + (finalTotal * 0.15);
                    }
                    break;
                case "Gladiolus":
                    finalTotal = flowerQty * 2.5;
                    if (flowerQty < 80)
                    {
                        finalTotal = finalTotal + (finalTotal * 0.2);
                    }
                    break;
            }
            if (budget>=finalTotal)
            {
                finalTotal=budget-finalTotal;
                Console.WriteLine($"Hey, you have a great garden with {flowerQty} {flowers} and {finalTotal:f2} leva left.");
            }
            else
            {
                finalTotal = finalTotal- budget;
                Console.WriteLine($"Not enough money, you need {finalTotal:f2} leva more.");
            }
        }
    }
}
